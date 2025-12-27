using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nescafe.Api.Models
{
    public class TransferPayload
    {
       public String coopCode { get; set; } = "";
        public String memberCode { get; set; } = "";
        public String benefCode { get; set; } = "";
        public Double amount { get; set; } 
        public Double fee { get; set; }
        public String transferRef { get; set; } = "";
        public String  remarks { get; set; } = "";
    }

    public class  BalancePayload 
    {
        public String memberCode { get; set; } = "";
        public Double amount { get; set; }
    }

    public class  MemberPayload
    {
        public String name { get; set; } = "";
        public String address { get; set; } = "";
        public String code { get; set; } = "";
        public String coopCode { get; set; } = "";
    }

    public class CoopPayload
    {
        public String name { get; set; } = "";
        public String address { get; set; } = "";
        public String code { get; set; } = "";
    }
}
