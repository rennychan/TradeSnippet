using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Script.Serialization;
using System.Text.Json;
namespace ConsoleTests
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string QUERY_URL = "https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol=IBM&interval=5min&apikey=demo"
            
            Uri queryUri = new Uri(QUERY_URL);

            using (WebClient client = new WebClient())
            {

                JavaScriptSerializer js = new JavaScriptSerializer();
                dynamic json_data = js.Deserialize(client.DownloadString(queryUri), typeof(object));

                dynamic json_data = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(client.DownloadString(queryUri));

            }
        }
    }
}
