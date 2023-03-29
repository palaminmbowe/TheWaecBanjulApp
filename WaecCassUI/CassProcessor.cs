using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure;
using WaecCassUI.Models;

namespace WaecCassUI
{
    public static class CassProcessor
    {
        private const string bearer = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoibWxtYm93ZUB3YWVjaW50bC5vcmciLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9lbWFpbGFkZHJlc3MiOiJtbG1ib3dlQHdhZWNpbnRsLm9yZyIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL3N1cm5hbWUiOiJNQk9XRSIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL2dpdmVubmFtZSI6Ik1VSEFNTUVEIExBTUlOIiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiQWRtaW5pc3RyYXRvcnMiLCJleHAiOjE2NjQ3MjI5MTAsImlzcyI6Imh0dHA6Ly9sb2NhbGhvc3QvY2Fzc2FwaSIsImF1ZCI6Imh0dHA6Ly9sb2NhbGhvc3QvY2Fzc2FwaSJ9.Wvbb7OxXvheJeEK9YX2MzFiVtrjDiDU0eCWxa4pbo7s";


        public static async Task<List<CandidateBioSubjects>> LoadCass(string centrePin, string startYear, string endYear)
        {
            if (centrePin.Equals(null))
            {
                throw new Exception("Empty school pin");
            }

            string url = "https://waecinternational.org/cassapi/school";

            using (var request = new HttpRequestMessage())
            {
                var responseFailMessage = "";

                request.RequestUri = new Uri(url);
                request.Method = HttpMethod.Get;
                request.Headers.Add("Accept", "*/*");
                request.Headers.Add("Authorization", bearer);

                //var bodyString = @"{  'centrePin': '" + centrePin + "',  '" + startYear + "': '2019',  '" + endYear + "': '2020}";
                var bodyString = "{  \"centrePin\": \"" + centrePin + "\",  \"startYear\": \"" + startYear + "\",  \"endYear\": \"" + endYear + "\"}";
                var content = new StringContent(bodyString, Encoding.UTF8, "application/json");
                request.Content = content;

                if (ApiHelper.ApiClient is null) ApiHelper.InitializeClient();

                if (ApiHelper.ApiClient is not null)
                {
                    using (var response = await ApiHelper.ApiClient.SendAsync(request))
                    {
                        if (response.IsSuccessStatusCode)
                        { //return new List<CassModel>(); 

                            try
                            {
                                //var result = await response.Content.ReadAsAsync<List<CassModel>>();
                                var result2 = await response.Content.ReadAsAsync<List<CandidateBioSubjects>>();

                                //if (ProcessCassData.AddCandidateBioSubject(result2))
                                //{

                                //    Console.WriteLine("Successfully saved records");
                                //}

                                return result2;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error converting CassModels: {ex.Message}");
                                responseFailMessage = $"Response exited with status code {response.StatusCode.ToString()} - with message: {ex.Message}";
                            }
                        }

                    }
                }

                throw new Exception($"Response failed: {responseFailMessage}");
            }
            
        }
    }
}
