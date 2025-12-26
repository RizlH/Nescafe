using Nescafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nescafe.Models
{
    public class Balance
    {
        public int Id { get; set; }
        public String MemberCode { get; set; }
        public decimal Amount { get; set; }
        public DateTime UpdateOn { get; set; }
        public string TransactionName { get; set; }
        public string Flow { get; set; }
    }
}