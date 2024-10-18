using System.Net.Http.Json;

namespace LedLampeHejs
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            HttpClient client = new()
            {
                BaseAddress = new Uri("http://192.168.1.100/api/ZjF1trs7iE8kKKYDI2P6Yt8HDGhOX89CPzgBJEhd/")
            };

            string inputCmd = string.Empty;
            do
            {
                inputCmd = Console.ReadLine() ?? string.Empty;

                var content = JsonContent.Create(new {ct = 153});

                var result = await client.PutAsync("lights/4/state", content);

                


                Console.WriteLine(await result.Content.ReadAsStringAsync());

            } while (inputCmd != "exit");
        }
    }
}
