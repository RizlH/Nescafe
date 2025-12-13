using Microsoft.EntityFrameworkCore;
using Nescafe.Data;
using Nescafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nescafe.Services
{
    public class BalanceService
    {
        private readonly AppDbContext _db;
        public BalanceService(AppDbContext db) => _db = db;

        public void setBalance(String memberCode)
        {
            Balance? balance = _db.Balances.FirstOrDefault(b => b.MemberCode == memberCode);
            if (balance == null)
            {
                balance = new Balance
                {
                    MemberCode = memberCode,
                    Amount = 0,
                    UpdateOn = DateTime.UtcNow,
                    TransactionName = "-",
                    Flow = "-"
                };
                _db.Balances.Add(balance);
                _db.SaveChanges();
            }
        }

        public async Task<Balance?> getBalance(String memberCode) 
        {
            return await _db.Balances.FirstOrDefaultAsync(b => b.MemberCode == memberCode);
        }

        public async void Update(Balance balance)
        {
            _db.Balances.Update(balance);
            await _db.SaveChangesAsync();
        }

    }
}
