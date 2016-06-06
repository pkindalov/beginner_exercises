using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] {' ', ',' , '.', '?', '!'};
            List<string> words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> result = new List<string>();

            foreach (var w in words)
            {

                if (w.Length == 1)
                {
                    if (!result.Contains(w))
                    {
                        result.Add(w);
                    }
                }

                for (int l = 0; l < w.Length / 2; l++)
                {
                    if (w[l] == w[w.Length - l - 1])
                    {
                        if (!result.Contains(w))
                        {
                            result.Add(w);
                        }
                        
                    }

                    

                }
            }


            Console.WriteLine(string.Join(", ", result.OrderBy(x => x)));
        }
    }
}
