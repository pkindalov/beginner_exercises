using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalization
{
    class Capitalization
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] {' ', '.', ',' , '?', '!', ';' };

            List<string> words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> result = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                string upperLetter = words[i][0].ToString().ToUpper();
                string change = words[i].Substring(1, words[i].Length - 1);
                string transformWord = upperLetter + change;
                result.Add(transformWord);
                //words[i] = words[i].Replace(words[i], upperLetter);
            }


            Console.WriteLine(string.Join(" ", result));
        }
    }
}
