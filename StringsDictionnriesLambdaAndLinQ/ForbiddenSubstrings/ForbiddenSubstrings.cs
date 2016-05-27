using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbiddenSubstrings
{
    class ForbiddenSubstrings
    {

        static private string searchWord(string text, string searchingWords)
        {
            int offset = -1;
            int pos = 0;
            int wordLength = 0;
            string stars = null;
            string removingShits = null;
            string addingStars = null;


            //if (string.Compare(text, searchingWords) == 0)
            if (text.Contains(searchingWords))
            {
                while (true)
                {
                    offset = text.IndexOf(searchingWords, offset + 1);
                    if (offset == -1)
                    {
                        wordLength = searchingWords.Length;
                        stars = new string('*', wordLength - 1);
                        removingShits = searchingWords.Remove(1, wordLength - 1);
                        addingStars = removingShits.Insert(1, stars);

                        //Console.WriteLine(addingStars);
                        //Console.WriteLine(searchingWords[pos]);
                        //Console.WriteLine(removingShits);
                        break;
                    }


                    pos++;
                }

                return addingStars;

            }
            else
            {
                return searchingWords;
            }
        }

           



        static void Main(string[] args)
        {


            string text = Console.ReadLine();
            string[] searchingWords = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < searchingWords.Length; i++)
            {
                Console.Write(searchWord(text, searchingWords[i]) + " ");
            }
            

            //string text = Console.ReadLine();
            //string[] searchingWords = Console.ReadLine().Split(' ').ToArray();

            //foreach (string word in searchingWords)
            //{
            //    text = text.Replace(word, new string('*', word.Length));
            //    Console.WriteLine(text);
            //}




            /////////////////////////////////////////////////////////////////////////////////////////

            //int offset = -1;
            //int pos = 0;

            //for (int i = 0; i < searchingWords.Length; i++)
            //{
            //    offset = text.IndexOf(searchingWords[i], offset + 1);

            //    if (offset == -1)
            //    {
            //        int wordLength = searchingWords[pos].Length;
            //        string stars = new string('*', wordLength - 1);
            //        string removingShits = searchingWords[pos].Remove(1, wordLength - 1);
            //        string addingStars = removingShits.Insert(1, stars);

            //        Console.WriteLine(addingStars);
            //    }

            //}

            /////////////////////////////////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////////////////////
            //Работи, но за 1 дума

            //int offset = -1;
            //int pos = 0;

            //while (true)
            //{
            //    offset = text.IndexOf(searchingWords[pos], offset + 1);
            //    if (offset == -1)
            //    {
            //        int wordLength = searchingWords[pos].Length;
            //        string stars = new string('*', wordLength - 1);
            //        string removingShits = searchingWords[pos].Remove(1, wordLength - 1);
            //        string addingStars = removingShits.Insert(1, stars);

            //        Console.WriteLine(addingStars);
            //        //Console.WriteLine(searchingWords[pos]);
            //        //Console.WriteLine(removingShits);
            //        break;
            //    }


            //    pos++;
            //}

            ////////////////////////////////////////////////////////////////////////////////////////

        }
    }
}
