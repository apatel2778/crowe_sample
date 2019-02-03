using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Crowe.Console
{
    public class Program
    {
        private static readonly HttpClient WebClient = new HttpClient();

        public static async Task Main(string[] args)
        {
            System.Console.WriteLine("Enter the text you want to send to API :");
            var textToSend = System.Console.ReadLine();

            var result = await SendToApi(textToSend);

            System.Console.WriteLine($"The result of api call is {result}");
        }

        private static async Task<string> SendToApi(string data)
        {
            WebClient.DefaultRequestHeaders.Accept.Clear();
            // NOTE: You need to replace the host var w/your local host and port #
            var host = "https://localhost:44337";
            var apiUrl = "/api/dataWriter";

            var stringTask = await WebClient.GetStringAsync(string.Concat(host, apiUrl, data));

            return stringTask;
        }
    }
}
