using System;
using System.Net;
using Newtonsoft.Json.Linq;

namespace ChuckNorris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getWebResponse("https://api.chucknorris.io/jokes/random"));

            Console.ReadLine();
        }

        static string getWebResponse(string url)
        {
            WebClient webClient = new WebClient();
            string apiResponse = webClient.DownloadString(url);
            string joke = JObject.Parse(apiResponse)["value"].ToString();
            return joke;           
        }      
    }
}
