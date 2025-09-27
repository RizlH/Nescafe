using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraveHeroCooperation.Models
{
    public class LoanMaster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Interest { get; set; }
        public int Tenor { get; set; }
        public decimal Fine { get; set; }
        public decimal MinAmount { get; set; } = 0;
        public decimal MaxAmount { get; set; } = 0;
        public decimal AdminFee { get; set; } = 0;
        public DateTime UpdateOn { get; set; }
    }
}
