using Nescafe.Data;
using Nescafe.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Nescafe.Services
{
    public class LoanService
    {
        AppDbContext _db;
        public LoanService(AppDbContext db) {
            _db = db;
        }

        public async Task<Loan?> findById(int id)
        {
            return await _db.Loans.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Installment>> LoadInstallmentsGrid(int loanId)
        {
            return await _db.Installments.Where(x => x.LoanId == loanId)
                .ToListAsync();
        }

        public async Task<List<Loan>> LoadLoanGrid(int memberId)
        {
            return await _db.Loans
                .Where(x => x.MemberId == memberId)
                .OrderByDescending(x => x.CreatedOn).ToListAsync();
        }

        public async Task SaveOrUpdate(Member member, string amount, string ktp, string kk, string slip,
                                       string dueDate, string interest, string interestFine, string loanId,
                                       string tenor, string adminFee)
        {
            int tenorLeft = int.Parse(tenor);
            decimal decAmount = decimal.Parse(amount);
            decimal decInterest = decimal.Parse(interest);
            decimal outstanding = (decAmount * (decInterest / 100) * tenorLeft) + decAmount;

            Loan l = new Loan
            {
                Amount = decAmount,
                CreatedOn = DateTime.UtcNow,
                DueDate = int.Parse(dueDate),
                Interest = decInterest,
                InterestFine = decimal.Parse(interestFine),
                KkPath = kk,
                KtpPath = ktp,
                SlipGajiPath = slip,
                LoanId = int.Parse(loanId),
                Tenor = tenorLeft,
                TenorLeft = tenorLeft,
                MemberId = member.Id,
                AdminFee = decimal.Parse(adminFee),
                Outstanding = outstanding,
                TotalAmount = outstanding + decimal.Parse(adminFee)
            };
            _db.Loans.Add(l);
            await _db.SaveChangesAsync();
        }

        /*public object LoadApproval()
        {
            return _db.Loan.Where(x => x.ApprovedOn = null)
                .Include(x => x.Member)
                .OrderByAscending(x => x.CreatedOn)
                .Select(x => new
                {
                    x.id,
                    MemberData = x.Member.MemberId + " _ " + x.Member.FullName,
                    JoinDate = x.Member.JoinDate.ToString("f"),
                    x.LoanId,
                    x.Amount,
                    x.Outstanding,
                    RequestDate = x.CreatedOn.ToString("f"),
                    x.Tenor,
                    x.Interest,
                    Kk = x.KkPath,
                    Ktp = x.KtpPath,
                    Slip = x.SlipGajiPath
                })
                .ToList();
        }*/

        public async Task<List<Loan>> LoadsApproval()
        {
            return await _db.Loans
                .Where(x => x.ApprovedOn == null)
                .Include(x => x.Member)
                .OrderByDescending(x => x.CreatedOn)
                .ToListAsync();
        }

        public async Task SetApproval(int id, bool isApprove)
        {
            Loan? l = await _db.Loans.FirstOrDefaultAsync(x => x.Id == id);
            if (l != null)
            {
                l.ApprovedOn = DateTime.UtcNow;
                if (isApprove)
                    l.IsApproved = true;
                else
                    l.IsApproved = false;
                _db.Loans.Update(l);
                await _db.SaveChangesAsync();
            }
        }

        public async Task saveOrUpdateInstallment(int loanId, string amount, string path)
        {
            Installment i = new Installment
            {
                LoanId = loanId,
                amount = decimal.Parse(amount),
                PaymentDate = DateTime.UtcNow,
                ProofPath = path
            };
            _db.Installments.Add(i);
            await _db.SaveChangesAsync();
        }

        public async Task recalculateLoan(int idLoan, string amount)
        {
            decimal payment = decimal.Parse(amount);
            int todaysDate = DateTime.UtcNow.Day;
            Loan? l = await _db.Loans.FirstOrDefaultAsync(x => x.Id == idLoan);
            if (l != null)
            {
                if (todaysDate > l.DueDate)
                {
                    l.Fine = (l.Amount * l.InterestFine) + l.Fine;
                    l.TotalAmount += l.Fine;
                }

                l.Outstanding -= payment;
                l.TotalAmount -= payment;

                if (l.Outstanding <= 0 && l.TotalAmount > 0)
                    l.TenorLeft = 1;
                else if (l.TotalAmount <= 0)
                    l.TenorLeft = 0;
                else
                    l.TenorLeft = l.TenorLeft - 1;

                _db.Loans.Update(l);
                await _db.SaveChangesAsync();
            }
        }
    }
}
