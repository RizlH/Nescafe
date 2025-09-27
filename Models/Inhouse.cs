using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nescafe.Models
{
    internal class Inhouse
    {
        public int Id { get; set; }
        [Required] public int OriginId { get; set; }
        public Member Origin { get; set; }
        [Required] public int DestinationId { get; set; }
        public Member Destination { get; set; }
        public decimal Amount { get; set; }
        public decimal Fee { get; set; }  
        public string Remarks { get; set; }
        public DateTime TransferDate { get; set; }
        public string TransferId { get; set; }
    }
}
