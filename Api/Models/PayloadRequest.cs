using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nescafe.Api.Models
{
    public class TransferPayload
    {
        public string coopCode { get; set; } = "";
        public string memberCode { get; set; } = "";
        public string benefCode { get; set; } = "";
        public double amount { get; set; }
        public double fee { get; set; }
        public string transferRef { get; set; } = "";
        public string remarks { get; set; } = "";
    }

    public class BalancePayload
    {
        public string memberCode { get; set; } = "";
        public double amount { get; set; }
    }

    public class MemberPayload
    {
        public string name { get; set; } = "";
        public string address { get; set; } = "";
        public string code { get; set; } = "";
        public string coopCode { get; set; } = "";
    }

    public class CoopPayload
    {
        public string name { get; set; } = "";
        public string address { get; set; } = "";
        public string code { get; set; } = "";
    }
}
