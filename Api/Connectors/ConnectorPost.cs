using Nescafe.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Nescafe.Api.Connectors
{
    public class ConnectorPost
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private string _baseUrl = "http://103.82.242.90:20254/";

        public async Task<CoopApiResponse> CoopRegistrationAsync(CoopPayload data)
        {
            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            string json = JsonSerializer.Serialize(data, options);

            var requestUrl = $"{_baseUrl.TrimEnd('/')}/coop/save";
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync(requestUrl, content);
            response.EnsureSuccessStatusCode();

            string responseJson = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<CoopApiResponse>(responseJson,
               new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<MemberApiResponse> MemberRegistrationAsync(MemberPayload data)
        {
            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            string json = JsonSerializer.Serialize(data, options);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync(_baseUrl + "member/new", content);
            response.EnsureSuccessStatusCode();

            string responseJson = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<MemberApiResponse>(responseJson,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<BalanceApiResponse> BalanceUpdateAsync(BalancePayload data)
        {
            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            string json = JsonSerializer.Serialize(data, options);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync(_baseUrl + "balance/sync", content);
            response.EnsureSuccessStatusCode();

            string responseJson = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<BalanceApiResponse>(responseJson,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<TransferApiResponse> TransferAsync(TransferPayload data)
        {
            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            string json = JsonSerializer.Serialize(data, options);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var requestUrl = $"{_baseUrl.TrimEnd('/')}/transfer/save";

            HttpResponseMessage response = await _httpClient.PostAsync(requestUrl, content);
            response.EnsureSuccessStatusCode();

            string responseJson = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<TransferApiResponse>(responseJson,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}