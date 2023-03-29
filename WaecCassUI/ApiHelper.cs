using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaecCassUI
{
    public class ApiHelper
    {
        public static HttpClient? ApiClient { get; set; }

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}

//var client = new HttpClient();
//var request = new HttpRequestMessage();
//request.RequestUri = new Uri("https://waecinternational.org/cassapi/school");
//request.Method = HttpMethod.Get;

//request.Headers.Add("Accept", "*/*");
//request.Headers.Add("User-Agent", "Thunder Client (https://www.thunderclient.com)");
//request.Headers.Add("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoibWxtYm93ZUB3YWVjaW50bC5vcmciLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9lbWFpbGFkZHJlc3MiOiJtbG1ib3dlQHdhZWNpbnRsLm9yZyIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL3N1cm5hbWUiOiJNQk9XRSIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL2dpdmVubmFtZSI6Ik1VSEFNTUVEIExBTUlOIiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiQWRtaW5pc3RyYXRvcnMiLCJleHAiOjE2NjQ3MjI5MTAsImlzcyI6Imh0dHA6Ly9sb2NhbGhvc3QvY2Fzc2FwaSIsImF1ZCI6Imh0dHA6Ly9sb2NhbGhvc3QvY2Fzc2FwaSJ9.Wvbb7OxXvheJeEK9YX2MzFiVtrjDiDU0eCWxa4pbo7s");

//var bodyString = "{  \"centrePin\": \"80200052601024240\",  \"startYear\": \"2019\",  \"endYear\": \"2020\"}";
//var content = new StringContent(bodyString, Encoding.UTF8, "application/json");
//request.Content = content;

//var response = await client.SendAsync(request);
//var result = await response.Content.ReadAsStringAsync();
//Console.WriteLine(result);