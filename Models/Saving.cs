using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nescafe.Models
{
    internal class Saving
    {
        public int Id { get; set; }
        [Required] public int MemberId { get; set; }
        public Member Member { get; set; } = null!;
        [Required] public int SavingId { get; set; }
        public DateTime SavingDate { get; set; }
        public decimal Amount { get; set; }
        public decimal Fine { get; set; }
        public decimal WithdrawAmount { get; set; }
        public DateTime WithdrawDate { get; set; }
        public decimal Interest { get; set; }
        public decimal InterestFine { get; set; }
        public decimal Tenor { get; set; }
        public DateTime TargetDate { get; set; }

        [Required] public decimal TotalAmount { get; set; }

        
    }
}
