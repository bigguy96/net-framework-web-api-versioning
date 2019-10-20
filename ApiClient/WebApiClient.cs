using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Entities;
using Entities.DTO;

namespace ApiClient
{
    public class WebApiClient
    {
        private static HttpClient httpClient = new HttpClient();
        public WebApiClient()
        {
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

        public static async Task<User> PostAsync(UserDTO userDTO, string version = "1")
        {
            var path = $"http://localhost:44322/api/v{version}/home";
            var response = await httpClient.PostAsJsonAsync(path, userDTO);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<User>();
            }

            return new User();
        }

        public static async Task<User> PutAsync(UserDTO userDTO, string version = "1")
        {
            var path = $"http://localhost:44322/api/v{version}/home";
            var response = await httpClient.PutAsJsonAsync(path, userDTO);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<User>();
            }
            
            return new User();
        }

        public static async Task<HttpStatusCode> DeleteAsync(string version = "1")
        {
            var path = $"http://localhost:44322/api/v{version}/home";
            var response = await httpClient.DeleteAsync(path);

            return response.StatusCode;
        }
    }
}