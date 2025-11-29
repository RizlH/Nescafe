using Nescafe.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Nescafe.Api.Connectors
{
    public class ConnectorGet
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private String _baseUrl = "http://localhost:20254/";

        public async Task<CoopApiResponse?> GetCoopAsync()
        {
            var response = await _httpClient.GetAsync(_baseUrl + "/coop/list");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<CoopApiResponse>(json, options);
        }

        public async Task<MemberApiResponse?> GetAllMembersAsync()
        {
            var response = await _httpClient.GetAsync(_baseUrl + "/member/list");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<MemberApiResponse>(json, options);
        }

        public async Task<MemberApiResponse?> GetMembersByCoopAsync(string coopCode)
        {
            var response = await _httpClient.GetAsync(_baseUrl + "/member/list-by-coop/" + coopCode);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<MemberApiResponse>(json, options);
        }

        public async Task<MemberApiResponse?> GetMemberAsync(string memberCode)
        {
            var response = await _httpClient.GetAsync(_baseUrl + "/member/code/" + memberCode);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<MemberApiResponse>(json, options);
        }

        public async Task<BalanceApiResponse?> GetBalancesByCoopAsync(string coopCode)
        {
            var response = await _httpClient.GetAsync(_baseUrl + "/balance/coop/" + coopCode);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<BalanceApiResponse>(json, options);
        }

        public async Task<BalanceApiResponse?> GetBalanceByMemberAsync(string memberCode)
        {
            var response = await _httpClient.GetAsync(_baseUrl + "/balance/member/" + memberCode);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<BalanceApiResponse>(json, options);
        }

        public async Task<TransferApiResponse?> GetAllTransfersAsync()
        {
            var response = await _httpClient.GetAsync(_baseUrl + "/transfer/all-histories");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<TransferApiResponse>(json, options);
        }

        public async Task<TransferApiResponse?> GetOutgoingByMemberAsync(string memberCode)
        {
            var response = await _httpClient.GetAsync(_baseUrl + "/transfer/history/" + memberCode);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<TransferApiResponse>(json, options);
        }

        public async Task<TransferApiResponse?> GetIncomingByMemberAsync(string benefCode)
        {
            var response = await _httpClient.GetAsync(_baseUrl + "/transfer/incoming/" + benefCode);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<TransferApiResponse>(json, options);
        }

        public async Task<TransferApiResponse?> GetTransferByCodeAsync(string transferCode)
        {
            var response = await _httpClient.GetAsync(_baseUrl + "/transfer/code/" + transferCode);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<TransferApiResponse>(json, options);
        }

        public async Task<TransferApiResponse?> GetTransfersByCoopAsync(string coopCode)
        {
            var response = await _httpClient.GetAsync(_baseUrl + "/balance/coop/" + coopCode);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<TransferApiResponse>(json, options);
        }
    }
}