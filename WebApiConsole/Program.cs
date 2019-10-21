using System;
using System.Threading.Tasks;
using Entities.DTO;

namespace WebApiConsole
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var dto = new UserDTO { Id = "1", FirstName = "John", LastName = "Doe", Version="1" };
            var dto2 = new UserDTO { Id = "1", FirstName = "John", LastName = "Doe", Version = "2" };
            
            //Testing Web Api using the HttpClient
            await DisplayGet();
            await DisplayPost(dto, dto2);
            await DisplayPut(dto, dto2);
            await DisplayDelete();

            Console.ReadLine();
        }

        private static async Task DisplayGet()
        {
            var v1 = await ApiClient.WebApiClient.GetAsync();
            var v2 = await ApiClient.WebApiClient.GetAsync("2");

            Console.WriteLine("GET");
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(Environment.NewLine);
        }

        private static async Task DisplayPost(UserDTO dto, UserDTO dto2)
        {
            Console.WriteLine("POST");
            var post = await ApiClient.WebApiClient.PostAsync(dto);
            var postv2 = await ApiClient.WebApiClient.PostAsync(dto2, "2");

            Console.WriteLine($"{post.Id} {post.FirstName} {post.LastName} {post.Version}");
            Console.WriteLine($"{postv2.Id} {postv2.FirstName} {postv2.LastName} {postv2.Version}");
            Console.WriteLine(Environment.NewLine);
        }

        private static async Task DisplayPut(UserDTO dto, UserDTO dto2)
        {
            Console.WriteLine("PUT");
            var put = await ApiClient.WebApiClient.PutAsync(dto);
            var putv2 = await ApiClient.WebApiClient.PutAsync(dto2, "2");

            Console.WriteLine($"{put.Id} {put.FirstName} {put.LastName} {put.Version}");
            Console.WriteLine($"{putv2.Id} {putv2.FirstName} {putv2.LastName} {putv2.Version}");
            Console.WriteLine(Environment.NewLine);
        }

        private static async Task DisplayDelete()
        {
            Console.WriteLine("DELETE");
            var delete = await ApiClient.WebApiClient.DeleteAsync();
            var deletev2 = await ApiClient.WebApiClient.DeleteAsync("2");

            Console.WriteLine(delete);
            Console.WriteLine(deletev2);
        }
    }
}