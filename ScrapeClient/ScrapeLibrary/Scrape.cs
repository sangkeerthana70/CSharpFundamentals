using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeLibrary
{
    public class Scrape
    {


        public string ScrapeWebPage(string url)
        {
            return GetWebpage(url);
        }

        public string ScrapeWebPage(string url, string filepath)
        {
            string reply = GetWebpage(url);
            File.WriteAllText(filepath, reply);
            return reply;
        }

        //private helper method which gets the web page.
        private string GetWebpage(string url)
        {
            WebClient Client = new WebClient();
            string content = Client.DownloadString(url);
            content += "That's all FOLKS!!";
            return content;
        }
    }

}
