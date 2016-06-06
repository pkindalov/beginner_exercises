using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitStringIn20Chars
{
    class FitStringIn20Chars
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            if (text.Length <= 20)
            {
                text = text.PadRight(20, '*');
                Console.WriteLine(text);
            }
            else
            {
                text = text.Substring(0, 20);
                Console.WriteLine(text);
            }
        }
    }
}
