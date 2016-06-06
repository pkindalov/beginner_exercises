using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchWordsByChars
{
    class SearchWordsByChars
    {
        //static bool checkForWord(string word, List<string> letters)
        //{


        //}

        //static bool wordCheck(string word, List<string> letters)
        //{

        //int count = 0;
        //foreach (var l in letters)
        //{
        //    if (word.IndexOf(l) == -1)
        //    {
        //        count++;
        //    }
        //}

        //if(count > 0)
        //{
        //    return true;
        //}
        //else
        //{
        //    return false;
        //}
        //foreach (var ch in letters)
        //{
        //    if (word.Contains(ch))
        //    {
        //        count++;
        //    }
        //}

        //if (count == word.Length)
        //{
        //    return true;
        //}
        //else
        //{
        //    return false;
        //}
        //}




        static void Main(string[] args)
        {
            //List<string> wordsToFind = new List<string>() { "perrot", "orange", "pray", "milcho", "orange fruit", "parma", "parmalat", "dreamers", "dream", "dre", "dr.dre", "android" };
            //List<string> letters = Console.ReadLine().ToLower().Trim().Split().ToList();
            //List<string> result = new List<string>();

            //StreamReader MyReader = new StreamReader(@"C:/wordsDataBase.txt", System.Text.Encoding.Default);
            //string line = " ";
            //string line = string.Empty;
            //List<string> words = new List<string>();


            var wordsToFind = new List<string>();
            using (StreamReader reader = new StreamReader("C:/wordsDataBase.txt", System.Text.Encoding.Default))
            {
                string line = string.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    wordsToFind.Add(line);
                }
            }
            //while (line != null)
            //{
            //    line = MyReader.ReadLine();
            //    if (line != null)
            //    {
            //        words = line.Split().ToList();
            //    }


            //}

            //foreach (var word in words)
            //{
            //    foreach (var w in word)
            //    {
            //        Console.WriteLine(w);
            //    }
            //}

            //List<string> wordsToFind = new List<string>() { "perrot", "orange", "pray", "milcho", "orange fruit", "parma", "parmalat", "dreamers", "dream", "dre", "dr.dre", "android" };
            char[] separators = new char[] { ' ', ',' };
            List<string> letters = Console.ReadLine().ToLower().Trim().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> result = new List<string>();
            bool found = false;
            string newWord = string.Empty;

            newWord = letters[0] + letters[1] + letters[2] + letters[3] + letters[4] + letters[5] + letters[6] + letters[7] + letters[8] + letters[9] + letters[10] + letters[11];





            for (int i = 0; i < wordsToFind.Count; i++)
            {
                if (wordsToFind.Contains(newWord))
                {
                    result.Add(wordsToFind[i]);
                }
                //found = wordCheck(wordsToFind[i], letters);
                //if (found)
                //{
                //    result.Add(wordsToFind[i]);
                //}
            }


            Console.WriteLine(string.Join(" ", result));


            //string[] res;


            //for (int i = 0; i < wordsToFind.Count; i++)
            //{
            //    res = (wordsToFind.Where(
            //                str =>
            //                {
            //                    foreach (char ch in wordsToFind[i])
            //                    {
            //                        if (str.IndexOf(ch) == -1)
            //                            return false; // the word is missing a character(s)
            //                    }

            //                    // the word contains all characters
            //                    return true;
            //                }).ToArray());

            //    if (i > 10)
            //    {
            //        Console.WriteLine("do you want to continue: yes or no");
            //        string answer = Console.ReadLine();
            //        if (answer == "no") break;
            //        {

            //        }
            //    }

            //    Console.WriteLine(string.Join(" ", res));
            //}
                
               
            

            //for (int l = 0; l < letters.Count; l++)
            //{
            //    for (int w = 0; w < wordsToFind.Count; w++)
            //    {
            //        if (wordsToFind[w].Contains(letters[l]))
            //        {

            //            result.Add(wordsToFind[w]);
            //        }




            //    }
            //}


            //if (result.Count == 0)
            //{
            //    Console.WriteLine("Nothing found");
            //}
            //else
            //{
            //    int count = 1;
            //    long foundRes = result.Count;

            //    Console.WriteLine($"Were found {foundRes} results");

            //    foreach (var item in result)
            //    {

            //        if (count % 30 == 0)
            //        {
            //            Console.WriteLine(item);
            //            Console.WriteLine("Do you want more suggestions ? Yes or No");
            //            Console.WriteLine($"Results left {foundRes}");
            //            string doYouWantToContinue = Console.ReadLine().ToLower();

            //            if (doYouWantToContinue == "no" || doYouWantToContinue == "не")
            //            {
            //                break;
            //            }


            //            foundRes--;

            //        }
            //        Console.WriteLine($"Results left {foundRes - 30}");
            //        foundRes--;
            //        count++;
            //        Console.WriteLine(item);
            //    }
            //}

            Console.ReadLine();
        }
    }
}
