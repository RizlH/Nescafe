using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Nescafe.Models
{
    internal class Configuration
    {
        public int Id { get; set; }
        [MaxLength(4000)] public string terminologi1 { get; set; }
        [MaxLength(4000)] public string terminologi2 { get; set; }
        [MaxLength(4000)] public string terminologi3 { get; set; }
        public decimal exchangeRate { get; set; }
        public decimal transferAcrossFee { get; set; }
        public decimal transferInhouseFee { get; set; }
    }
}
