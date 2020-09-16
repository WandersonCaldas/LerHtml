using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string strSiteUrl = "URL";

            var request = (HttpWebRequest)WebRequest.Create(strSiteUrl);
            var response = (HttpWebResponse)request.GetResponse();
            var stream = response.GetResponseStream();
            var streamReader = new StreamReader(stream);
            //Console.WriteLine(streamReader.ReadToEnd());

            string[] lines = { streamReader.ReadToEnd() };
            System.IO.File.WriteAllLines(@"C:\Downloads\WriteLines.txt", lines);
        }
    }
}
