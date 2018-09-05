using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeLibrary
{
    public class Scrape
    {
        public string ScrapeWebPage(string url)
        {
            WebClient Client = new WebClient();
            return Client.DownloadString(url);

        }

        public string ScrapeWebPage(string url, string filepath)
        {
            WebClient Client = new WebClient();
            string reply = Client.DownloadString(url);
            
            File.WriteAllText(filepath, reply);
            return reply;
        }
    }
}
