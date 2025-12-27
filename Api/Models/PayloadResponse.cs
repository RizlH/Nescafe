using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Nescafe.Api.Models
{
    public class CoopApiResponse
    {
        public string? CoopCode { get; set; } 
        // ? = bisa menerima inputan null,
        // ! = nilainya pasti ada, tidak ada nilai null
        public string ResponseCode { get; set; } = "";
        public string ResponseMessage { get; set; } = "";
        public DateTime ResponseTime { get; set; }

        [JsonPropertyName("coopList")]
        public List<CoopAcross> CoopList { get; set; } = new();
    }

    public class MemberApiResponse
    {
        public string? MemberCode { get; set; }
        public string ResponseCode { get; set; } = "";
        public string ResponseMessage { get; set; } = "";
        public DateTime ResponseTime { get; set; }

        [JsonPropertyName("memberList")]
        public List<MemberAcross> MemberList { get; set; } = new();
    }

    public class BalanceApiResponse
    {
        public string ResponseCode { get; set; } = "";
        public string ResponseMessage { get; set; } = "";
        public DateTime ResponseTime { get; set; }
        public string? MemberCode { get; set; }
        public string? CoopCode { get; set; }
        public Double? Balance { get; set; }
        [JsonPropertyName("balanceList")]
        public List<BalanceAcross> BalanceList { get; set; } = new();
    }

    public class TransferApiResponse
    {
        public string ResponseCode { get; set; } = "";
        public string ResponseMessage { get; set; } = "";
        public DateTime ResponseTime { get; set; }
        public string? TransactionCode { get; set; }
        public TransferAcross? Transfer { get; set; }
        [JsonPropertyName("memberList")]
        public List<TransferAcross> TransferList { get; set; } = new();
    }
}
