using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using HtmlAgilityPack;

namespace CheckSite
{
    class Program
    {
        private HttpClient client = new HttpClient();
        public StreamWriter validLinks = new StreamWriter("validLinks.txt");
        public StreamWriter invalidLinks = new StreamWriter("invalidLinks.txt");
        private List<string> valid = new List<string>();
        private List<string> invalid = new List<string>();
        private List<string> allLinks = new List<string>();
        private List<string> otherLinks = new List<string> { "https://colorlib.com" };
        public string mainUrl = "http://91.210.252.240/broken-links/";


        public void Check()
        {
            valid.Add(mainUrl);
            for (int i = 0; i < valid.Count; ++i)
            {
                if (!otherLinks.Contains(valid[i]))
                {
                    var response = client.GetAsync(valid[i]).Result;
                    if (CheckResponse(response))
                    {
                        string page = response.Content.ReadAsStringAsync().Result;
                        var document = new HtmlDocument();
                        document.LoadHtml(page);
                        if (page != "")
                        {
                            var links = document.DocumentNode.SelectNodes("//a");
                            foreach (var link in links)
                            {
                                string temp = link.GetAttributeValue("href", null);
                                CheckLink(temp);
                            }
                        }
                    }
                }
            }
            /*Console.WriteLine(allLinks.Count + " - counter");
            Console.WriteLine(valid.Count + " - valid");
            Console.WriteLine(invalid.Count + " - invalid");*/
        }

        public void CheckLink(string url)
        {
            if (url != null && !url.Contains('#') )
            {
                string link;

                if (otherLinks.Contains(url))
                    link = url;
                else
                    link = mainUrl + url;

                var response = client.GetAsync(link).Result;
                if (!allLinks.Contains(link))
                {
                    if (CheckResponse(response))
                    {
                        valid.Add(link);
                        validLinks.WriteLine(link + " " + response.StatusCode.GetHashCode() + " " + response.ReasonPhrase);
                    }
                    else
                    {
                        invalid.Add(link);
                        invalidLinks.WriteLine(link + " " + response.StatusCode.GetHashCode() + " " + response.ReasonPhrase);
                    }
                }
                allLinks.Add(link);
            }
        }

        public bool CheckResponse(HttpResponseMessage httpResponse)
        {
            if (httpResponse.StatusCode.GetHashCode() < 300 && httpResponse.StatusCode.GetHashCode() >= 200)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            
            program.Check();

            Console.WriteLine("Hello World!");

            program.validLinks.WriteLine("\nCount links: " + program.valid.Count + "\nData Check: " + DateTime.UtcNow);
            program.validLinks.Close();

            program.invalidLinks.WriteLine("\nCount links: " + program.invalid.Count + "\nData Check: " + DateTime.UtcNow);
            program.invalidLinks.Close();

        }


    }
}
