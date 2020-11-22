using System;
using System.Net.Http;
using System.Text.Json;
//using HtmlAgilityPack;

namespace MockTry
{
    class Program
    {
        public HttpClient client = new HttpClient();

        public void CreateMountebank()
        {
            
        }

        static void Main(string[] args)
        {
            /*Program pr = new Program();
            //HttpClient cl = new HttpClient();
            var response = pr.client.GetAsync("http://localhost:44302/rate/euro").Result;
            //var response = pr.client.GetAsync("http://localhost:44302/rate/usdollar").Result;
            //HttpResponseMessage response = cl.GetAsync("http://localhost:44302/test").Result;
            Console.WriteLine(response.StatusCode.GetHashCode());
            string json = JsonSerializer.Serialize(response.Content.ReadAsStringAsync().Result);
            Console.WriteLine(json);
            Console.WriteLine();
            string temp = JsonSerializer.Deserialize<string>(json);
            Console.WriteLine(temp);
            */
        }
    }
}
