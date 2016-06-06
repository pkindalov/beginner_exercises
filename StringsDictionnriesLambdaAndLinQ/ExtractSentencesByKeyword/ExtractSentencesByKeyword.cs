using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSentencesByKeyword
{
    class ExtractSentencesByKeyword
    {
        static void Main(string[] args)
        {
            string searchingWord = Console.ReadLine().Trim();
            char[] separators = new char[] {'.', '!', '?'};
            string[] sentences = Console.ReadLine().Trim().Split(separators,StringSplitOptions.RemoveEmptyEntries);
            string[] words;


            foreach (var sentence in sentences)
            {
                if (sentence == " ")
                {
                    continue;
                }
                else
                {
                    words = sentence.Trim().Split(' ');
                    words = sentence.Replace(",", " ").Split(' ');
                    

                    if (words.Contains(searchingWord))
                    {
                        Console.WriteLine(sentence);
                    }
                }
               
            }

            //foreach (var sentence in sentences)
            //{
            //    if (sentence.Contains(searchingWord))
            //    {
            //        Console.WriteLine(sentence);
            //    }
            //}

        }
    }
}
