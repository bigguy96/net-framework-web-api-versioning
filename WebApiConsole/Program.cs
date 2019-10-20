using System;
using System.Threading.Tasks;
using Entities;
using Entities.DTO;

namespace WebApiConsole
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var dto = new UserDTO { Id = "1", FirstName = "John", LastName = "Doe", Version="1" };
            var dto2 = new UserDTO { Id = "1", FirstName = "John", LastName = "Doe", Version = "2" };
            var v1 = await ApiClient.WebApiClient.GetAsync();
            var v2 = await ApiClient.WebApiClient.GetAsync("2");

            Console.WriteLine("GET");
            Console.WriteLine(v1);
            Console.WriteLine(v2);

            Console.WriteLine("POST");
            var post = await ApiClient.WebApiClient.PostAsync(dto);
            var postv2 = await ApiClient.WebApiClient.PostAsync(dto2, "2");

            Console.WriteLine("PUT");
            var put = await ApiClient.WebApiClient.PutAsync(dto);
            var putv2 = await ApiClient.WebApiClient.PutAsync(dto2, "2");

            Console.WriteLine("DELETE");
            var delete = await ApiClient.WebApiClient.DeleteAsync();
            var deletev2 = await ApiClient.WebApiClient.DeleteAsync("2");

            Console.ReadLine();
        }
    }
}
