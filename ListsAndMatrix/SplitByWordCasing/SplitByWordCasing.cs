using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            string sentences = Console.ReadLine();
            char[] template = new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/' , '\\' , '[' , ']', ' '
            };

            List<string> lowerCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();

            List<string> word = sentences.Split(template).ToList();

            foreach (var w in word)
            {
                int lower = 0;
                int upper = 0;
                

                if(w != "")
                {
                    foreach (char letter in w)
                    {
                        if(char.IsLower(letter))
                        {
                            lower++;
                        }else if(char.IsUpper(letter))
                        {
                            upper++;
                        }


                    }


                    if (lower == w.Length)
                    {
                        lowerCaseWords.Add(w);
                    }else if(upper == w.Length)
                    {
                        upperCaseWords.Add(w);
                    }else
                    {
                        mixedCaseWords.Add(w);
                    }
                



                }

            }

            Console.Write("lower-case: ");
            Console.WriteLine(string.Join(", ", lowerCaseWords));
            Console.Write("upper-case: ");
            Console.WriteLine(string.Join(", ", upperCaseWords));
            Console.Write("mixed-case: ");
            Console.WriteLine(string.Join(", ", mixedCaseWords));



        }
    }
}
