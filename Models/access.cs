using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nescafe.Models
{
    public class Access
    {
        public int id { get; set; }
        [Required] public int memberid { get; set; }
        public Member Member { get; set; } = null!;
        [Required] public string Accesslist { get; set; }
        public DateTime updateOn { get; set; } 
    }
}
