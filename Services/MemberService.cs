using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Nescafe.Data;
using Nescafe.Models;
using Nescafe.Models;

namespace Nescafe.Services
{
    public class MemberService
    {
        private readonly AppDbContext _db;
        public MemberService(AppDbContext db) => _db = db;
        public List<object> SetDropdown()
        {
            var list = _db.Members.OrderBy(m => m.FullName)
                .Select(m => new
                {
                    m.Id,
                    DisplayName = m.MemberId + " - " + m.FullName
                })
                .ToList<object>();
            return list;
        }

        public Member? FindById(int id)
        {
            return _db.Members.FirstOrDefault(x => x.Id == id);
        }

        public List<Member> SetGrid()
        {
            return _db.Members.OrderByDescending(m => m.ModDate).ToList<Member>();
        }

        public async void Update(Member member)
        {
            _db.Members.Update(member);
            await _db.SaveChangesAsync();
        }
    }
}
