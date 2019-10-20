using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ApiClient
{
    public class WebApiClient
    {
        private static HttpClient httpClient = new HttpClient();
        public WebApiClient()
        {
            //httpClient.BaseAddress = new Uri("http://localhost:44322/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<string> GetAsync(string version = "1")
        {
            var path = $"http://localhost:44322/api/v{version}/home";
            var response = await httpClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<string>();
            }
            return string.Empty;
        }
    }
}