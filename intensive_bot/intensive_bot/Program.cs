using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using System.Net;

namespace intensive_bot
{
    class Program
    {
        static void Main(string[] args)
        {
            int update_id = 0;
            string messageFromId = "";
            string messageText = "";
            string first_name = "";
            string token = "594904432:AAFPNbUe2fNeSs9Z7CJCMnwbdx-4d74DjEQ";

            WebClient webClient = new WebClient();

            string startUrl = $"https://api.telegram.org/bot{token}";

            while (true)
            {
                startUrl = $"{startUrl}/getUpdte?offset={update_id = 1}";
                string response = webClient.DownloadString(url);

                var array =  JObject.Parse(response)["result"].ToArray();

            

            }

        }
    }
}
