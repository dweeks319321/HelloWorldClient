using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldClient
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string text = client.DownloadString("http://localhost:61395//api/ReturnTextAPI/GetReturnText");
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
