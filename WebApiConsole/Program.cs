using System;
using System.Threading.Tasks;

namespace WebApiConsole
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var v1 = await ApiClient.WebApiClient.GetAsync();
            var v2 = await ApiClient.WebApiClient.GetAsync("2");

            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.ReadLine();
        }
    }
}
