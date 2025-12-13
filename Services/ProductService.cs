using System;
using Nescafe.Data;
using Nescafe.Models;
using Microsoft.EntityFrameworkCore;
using Nescafe.Models;

namespace Nescafe.Services
{
    public class ProductService
    {
        private AppDbContext _db;
        public ProductService(AppDbContext db)
        {
            _db = db;
        }

        public List<LoanMaster> LoadLoanGrid()
        {
            return _db.LoanMasters.OrderByDescending(x => x.UpdateOn).ToList();
        }

        public List<SavingMaster> LoadSavingGrid()
        {
            return _db.SavingMasters.OrderByDescending(x => x.UpdateOn).ToList();
        }

        public async Task SaveOrUpdateLoan(string id, string adminFee, string name,
            string fine, string interest, string maxAmount, string minAmount,
            string tenor)
        {
            LoanMaster? lm = new LoanMaster();
            bool isNew = true;
            if (id != null && id.Trim() != "" && id.Trim() != "...")
            {
                isNew = false;
                int idLoanMaster = int.Parse(id);
                lm = _db.LoanMasters.FirstOrDefault(lm => lm.Id == idLoanMaster);
            }

            lm.UpdateOn = DateTime.UtcNow;
            lm.Fine = decimal.Parse(fine.Replace(".", ","));
            lm.Interest = decimal.Parse(interest.Replace(".", ","));
            lm.AdminFee = decimal.Parse(adminFee);
            lm.MaxAmount = decimal.Parse(maxAmount);
            lm.MinAmount = decimal.Parse(minAmount);
            lm.Name = name;
            lm.Description = "-";
            lm.Tenor = int.Parse(tenor);

            if (isNew)
                _db.LoanMasters.Add(lm);
            else
                _db.LoanMasters.Update(lm);
            await _db.SaveChangesAsync();
        }

        public async Task SaveOrUpdateSaving(string id, string adminFee, string name,
            string fine, string interest, string maxAmount, string minAmount,
            string tenor)
        {
            SavingMaster? sm = new SavingMaster();
            bool isNew = true;
            if (id != null && id.Trim() != "" && id.Trim() != "...")
            {
                isNew = false;
                int idSavingMaster = int.Parse(id);
                sm = _db.SavingMasters.FirstOrDefault(lm => lm.Id == idSavingMaster);
            }

            sm.UpdateOn = DateTime.UtcNow;
            sm.Fine = decimal.Parse(fine.Replace(".", ","));
            sm.Interest = decimal.Parse(interest.Replace(".", ","));
            sm.AdminFee = decimal.Parse(adminFee);
            sm.MaxAmount = decimal.Parse(maxAmount);
            sm.MinAmount = decimal.Parse(minAmount);
            sm.Name = name;
            sm.Description = "-";
            sm.Tenor = int.Parse(tenor);

            if (isNew)
                _db.SavingMasters.Add(sm);
            else
                _db.SavingMasters.Update(sm);
            await _db.SaveChangesAsync();
        }

        public async Task<LoanMaster?> FindLoanById(int id)
        {
            return await _db.LoanMasters.FirstOrDefaultAsync(lm => lm.Id == id);
        }

        public async Task<SavingMaster?> FindSavingById(int id)
        {
            return await _db.SavingMasters.FirstOrDefaultAsync(lm => lm.Id == id);
        }

        public object SetDropDownSaving()
        {
            var data = _db.LoanMasters.OrderBy(x => x.Name)
                .Select(x => new
                {
                    x.Id,
                    DisplayName = x.Name + ", t:" + x.Tenor + "(" + x.Interest + ")"
                }).ToList();

            var result = new List<object>
            {
                new { Id = 0, DisplayName = "--choose--" }
            };

            // Gabungkan data asli
            result.AddRange(data);

            return result;
        }
    }
}
