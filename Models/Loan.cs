using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraveHeroCooperation.Models
{
    public class Loan
    {
        public int Id { get; set; }
        [Required] public int MemberId { get; set; }
        public Member Member { get; set; } = null!;
        [Required] public int LoanId { get; set; }
        [Required] public decimal Amount { get; set; }
        [Required] public decimal Outstanding { get; set; }
        public decimal Fine { get; set; }
        public int TenorLeft { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        [Required, MaxLength(20)] public string Status { get; set; } = "Pending";
        public decimal Interest { get; set; }
        public decimal InterestFine { get; set; }
        public decimal Tenor { get; set; }
        public int DueDate { get; set; }
        [Required] public decimal TotalAmount { get; set; }
        public bool IsApproved { get; set; } = false;
        public DateTime? ApprovedOn { get; set; }
        public decimal AdminFee { get; set; }

        public string? KtpPath { get; set; }
        public string? KkPath { get; set; }
        public string? SlipGajiPath { get; set; }

        public ICollection<Installment> Installments { get; set; } = new List<Installment>();
    }
}
