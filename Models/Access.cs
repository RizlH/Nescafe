using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nescafe.Models;

namespace BraveHeroCooperation.Models
{
    public class Access
    {
        public int Id { get; set; }
        [Required] public int MemberId { get; set; }
        public Member member { get; set; } = null!;
        [Required] public string AccessList { get; set; }
        public DateTime updateOn { get; set; }
    }
}
