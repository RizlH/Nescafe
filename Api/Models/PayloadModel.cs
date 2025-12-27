using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Nescafe.Api.Models
{
    public class CoopAcross
    {
        public int Id { get; set; }
        public string Code { get; set; } = "";
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public Boolean isDelete { get; set; }
    }

    public class MemberAcross
    {
        public int Id { get; set; }
        public string Code { get; set; } = "";
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public CoopAcross Coop { get; set; } = new CoopAcross();
    }

    public class BalanceAcross
    {
        public int Id { get; set; }
        public Double Amount { get; set; }
        public MemberAcross Member { get; set; } = new MemberAcross();
    }

    public class TransferAcross
    {
        public int Id { get; set; }
        public Double Amount { get; set; }
        public Double Fee { get; set; }
        public Double TotalAmount { get; set; }
        public string CodeOrigin { get; set; } = "";
        public string CodeBenef { get; set; } = "";
        public string Code { get; set; } = "";
        public string TransferRef { get; set; } = "";
        public string Remarks { get; set; } = "";
        public string CoopCode { get; set; } = "";
    }

    
}
