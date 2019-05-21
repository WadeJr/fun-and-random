using HtmlAgilityPack;
using System;
using System.IO;
using System.Net;

namespace AmazonConsole
{
    class Program
    {



        static public HtmlDocument htmlDocument = new HtmlDocument();

        static void Main(string[] args)
        {

            Console.WriteLine(GetVolume("baby bottle small"));
           
        
            Console.WriteLine("Done");
            Console.ReadLine();
        }

        public static void SetHtml(string url)
        {
            string urlResponse = URLRequest(url);
            htmlDocument.LoadHtml(urlResponse);
        }

        public static string GetVolume(string search)
        {

            string url = "https://www.merchantwords.com/search/us/";
            string q = "";
            foreach(var letter in search)
            {
                if(letter == ' ')
                {
                    q += "%20";
                }
                else
                {
                    q += letter;
                }
            }
            url += q + @"/sort-highest";
            SetHtml(url);
         
        
            var volume = htmlDocument.DocumentNode.SelectNodes("//td");

            return volume[3].InnerText;
        }

    

        static string URLRequest(string url)
        {
            // Prepare the Request
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            // Set method to GET to retrieve data
            request.Method = "GET";
            request.Timeout = 6000; //60 second timeout
            request.UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows Phone OS 7.5; Trident/5.0; IEMobile/9.0)";

            string responseContent = null;

            // Get the Response
            using (WebResponse response = request.GetResponse())
            {
                // Retrieve a handle to the Stream
                using (Stream stream = response.GetResponseStream())
                {
                    // Begin reading the Stream
                    using (StreamReader streamreader = new StreamReader(stream))
                    {
                        // Read the Response Stream to the end
                        responseContent = streamreader.ReadToEnd();
                    }
                }
            }

            return (responseContent);
        }
    }
}

