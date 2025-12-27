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
        private String _baseUrl = "http://103.82.242.90:20254/";

        public async Task<CoopApiResponse?> GetCoopAsync()
        {
            var response = await _httpClient.GetAsync(_baseUrl + "coop/list");
            response.EnsureSuccessStatusCode(); // 2**

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<CoopApiResponse>(json, options);
        }

        public async Task<MemberApiResponse?> GetAllMembersAsync()
        {
            var response = await _httpClient.GetAsync(_baseUrl + "member/list");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<MemberApiResponse>(json, options);
        }

        public async Task<MemberApiResponse?> GetMembersByCoopAsync(String coopCode)
        {
            var response = await _httpClient.GetAsync(_baseUrl + "member/list-by-coop/" + coopCode);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<MemberApiResponse>(json, options);
        }

        public async Task<MemberApiResponse?> GetMemberAsync(String memberCode)
        {
            var response = await _httpClient.GetAsync(_baseUrl + "member/code/" + memberCode);
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
            var response = await _httpClient.GetAsync(_baseUrl + "balance/coop/" + coopCode);
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
            var response = await _httpClient.GetAsync(_baseUrl + "balance/member/" + memberCode);
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
            var response = await _httpClient.GetAsync(_baseUrl + "transfer/all-histories");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<TransferApiResponse>(json, options);
        }

        /*public async Task<TransferApiResponse?> GetOutgoingByMemberAsync(String memberCode)
        {
            var response = await _httpClient.GetAsync(_baseUrl + "transfer/history/" + memberCode);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<TransferApiResponse>(json, options);
        }*/

        public async Task<TransferApiResponse?> GetOutgoingByMemberAsync(string memberCode)
        {
            var json = "";
            try
            {
                //MessageBox.Show("Outgoing: " + $"{_baseUrl}transfer/history/{memberCode}");
                
                var response = await _httpClient.GetAsync($"{_baseUrl}transfer/history/{memberCode}");

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("HTTP Error: " + response.StatusCode);
                    return null;
                }

                json = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrWhiteSpace(json))
                {
                    MessageBox.Show("Empty JSON response");
                    return null;
                }

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                return JsonSerializer.Deserialize<TransferApiResponse>(json, options);
            }
            catch (JsonException ex)
            {
                MessageBox.Show("JSON error: " + ex.Message);
                MessageBox.Show("Raw JSON: " + json);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("General error: " + ex.Message);
                return null;
            }
        }


        public async Task<TransferApiResponse?> GetIncomingByMemberAsync(String benefCode)
        {
            var response = await _httpClient.GetAsync(_baseUrl + "transfer/incoming/" + benefCode);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<TransferApiResponse>(json, options);
        }

        public async Task<TransferApiResponse?> GetTransferByCodeAsync(String transferCode)
        {
            var response = await _httpClient.GetAsync(_baseUrl + "transfer/code/" + transferCode);
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
            var response = await _httpClient.GetAsync(_baseUrl + "balance/coop/" + coopCode);
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
