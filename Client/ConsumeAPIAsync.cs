using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class ConsumeAPIAsync
    {
        public void GetMessageFromAPI()
        {
            using (var client = new WebClient())
            {
                //Setting the http headers 
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                //Consuming web Service to get the data exposed by the service as a string
                var result = client.DownloadString(ConfigurationSettings.AppSettings["GetHelloMessageURL"]);
                Console.WriteLine(Environment.NewLine + result);
            }
        }
    }
}
