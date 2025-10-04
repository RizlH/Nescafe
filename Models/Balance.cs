using Nescafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraveHeroCooperation.Models
{
    public class Balance
    {
        public int Id { get; set; }
        public Member member { get; set; }
        public decimal amount { get; set; }
        public DateTime updateOn { get; set; }
        public string transactionName { get; set; }
        public string flow { get; set; }
    }
}