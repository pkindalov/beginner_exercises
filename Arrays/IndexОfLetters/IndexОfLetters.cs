using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexОfLetters
{
    class IndexОfLetters
    {
        static void Main(string[] args)
        {
            char[] alphabetLetters = new char[26];

            for (int i = 0; i < alphabetLetters.Length; i++)
            {
                alphabetLetters[i] = (char)(97 + i);
            }


            string word = Console.ReadLine();

            for (int w = 0; w < word.Length; w++)
            {
                for (int alphabet = 0; alphabet < alphabetLetters.Length; alphabet++)
                {
                    if (word[w] == alphabetLetters[alphabet])
                    {
                        //Console.Write(alphabet + " ");
                        Console.WriteLine($"{word[w]} -> {alphabet}");
                    }
                }
            }
            //for (char letter = 'a'; letter <= 'z'; letter++)
            //{
            //    alphabetLetters[letter] = letter;
            //}


            //foreach (var letter in alphabetLetters)
            //{
            //    Console.Write(letter + " ");
            //}


        }
    }
}
