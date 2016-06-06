using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeТoUppercase
{
    class ChangeТoUppercase
    {
        static void Main(string[] args)
        {
            //string sometext = Console.ReadLine();
            //string upcase = "<upcase>";
            //string closetag = "</upcase>";
            //int start = sometext.IndexOf("<upcase>");
            //int stop = sometext.IndexOf("</upcase");
            //int upcaseLength = upcase.Length;
            //int closetagLength = closetag.Length;

            //int length = stop - start;

            //string transformText = sometext.Substring(start + upcaseLength, (length - closetagLength) + 1);

            //Console.WriteLine(transformText.ToUpper());


            string sometext = Console.ReadLine();
            string upcase = "<upcase>";
            string closetag = "</upcase>";
            int start = 0;
            int stop = 0;
            int upcaseLength = upcase.Length;
            int closetagLength = closetag.Length;

            while (true)
            {
                start = sometext.IndexOf("<upcase>", start + 1);
                stop = sometext.IndexOf("</upcase>", stop + 1);
                
                if (start < 0 && stop < 0)
                {
                    break;
                }
                int length = stop - start;
                string transformText = sometext.Substring(start + upcaseLength, (length - closetagLength) + 1);


                sometext = sometext.Replace(transformText, transformText.ToUpper());
               
                
                //Console.WriteLine(transformText.ToUpper());
            }
            sometext = sometext.Replace(upcase, "");
            sometext = sometext.Replace(closetag, "");
            Console.WriteLine(sometext);
        }
    }
}
