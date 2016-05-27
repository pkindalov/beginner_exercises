using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintStringLetters
{
    class PrintStringLetters
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            int pos = 0;

            do
            {
                char ch = text[pos];
                Console.WriteLine("str[{0}] -> '{1}'", pos, ch);
                pos++;

            } while (text.Length > pos );

        }
    }
}
