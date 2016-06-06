using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLParser
{
    class URLParser
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int protocolPos = text.IndexOf("://");
            string protocol = string.Empty;
            string server = string.Empty;
            string resources = string.Empty;

            if (protocolPos > 0)
            {
                protocol = text.Substring(0, protocolPos);

                int findServerPos = text.IndexOf("/", protocolPos + 3);


                if (findServerPos > 0)
                {
                    server = text.Substring(protocolPos + 3, findServerPos - protocolPos - 3);
                    resources = text.Substring(findServerPos + 1);
                }
                else
                {
                    server = text.Substring(protocolPos + 3);
                }
            }
            else
            {
                server = text;
            }
           


            
            

            Console.WriteLine($"[protocol] = \"{protocol}\"");
            Console.WriteLine($"[server] = \"{server}\"");
            Console.WriteLine($"[resource] = \"{resources}\"");
        }
    }
}
