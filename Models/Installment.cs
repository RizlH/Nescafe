using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nescafe.Models
{
    internal class Installment
    {
        public int Id { get; set; }
        [Required] public int LoanId { get; set; }
        public Loan Loan { get; set; }
        [Required] public decimal amount { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;
        public string? ProofPath { get; set; }
<<<<<<< HEAD
    } 
}
=======
    }
}
>>>>>>> 4967718ad46d9b8a01a632a10f2384c8b7aa8537
