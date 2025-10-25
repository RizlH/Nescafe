using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nescafe.Models
{
    public class Exchange
    {
        public int Id { get; set; }
        [Required] public int MemberId { get; set; }
        public Member Member { get; set; } = null!;
        public string ExchangeId { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountExchanged { get; set; }
        public decimal Fee { get; set; }
        public decimal Rate { get; set; }
        public DateTime ExchangeDate { get; set; }
        public decimal TotalAmountExchanged { get; set; }
    }
}
