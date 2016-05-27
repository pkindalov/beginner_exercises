using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OccurrencesInString
{
    class OccurrencesInString
    {
        static private int searching(string text, string word)
        {
            int count = 0;
            int offset = -1;

            while (true)
            {
                offset = text.IndexOf(word, offset + 1);
                if (offset == -1)
                {
                    break;
                }
                count++;
            }

            return count;

        }



        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();

            //int count = 0;
            //int offset = -1;

            //while (true)
            //{

            //    offset = text.IndexOf(word, offset + 1);
            //    if (offset == -1)
            //    {
            //        break;
            //    }
            //    count++;
            //}
            //Console.WriteLine($"Occurrencies: {count}");



            //second way
            Console.WriteLine($"Occurrencies: " + searching(text, word));





        }
    }
}
