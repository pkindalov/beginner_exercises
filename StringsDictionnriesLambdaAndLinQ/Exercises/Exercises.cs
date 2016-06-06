using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercises
{
    class Exercises
    {
        static void Main(string[] args)
        {
            //letter count - works
            //string text = Console.ReadLine();
            //int[] charsCount = new int[text.Max() + 1];

            //for (int i = 0; i < text.Length; i++)
            //{
            //    charsCount[text[i]]++;
            //}


            //for (int i = 0; i < charsCount.Length; i++)
            //{
            //    if (charsCount[i] > 0)
            //    {
            //        Console.WriteLine($"{(char)i} -> {charsCount[i]}");
            //    }
            //}

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //Count Occurrences in String

            //string text = Console.ReadLine();
            //string word = Console.ReadLine();
            //int count = 0;
            //int positon = -1;
            //int foundOnPos = 0;

            //while (true)
            //{
            //    positon = text.IndexOf(word, positon + 1);
            //    if (positon > - 1)
            //    {
            //        foundOnPos = positon;
            //    }

            //    if (positon == -1)
            //    {
            //        break;
            //    }
            //    count++;
            //}


            //Console.WriteLine("Number of occurencies: " + count);
            //Console.WriteLine("Found on position: " + foundOnPos);


            ///////////////////////////////////////////////////////////////////////////////////////////////

            //Change Forbidden Substrings

            //string text = Console.ReadLine().ToLower();
            //string[] words = Console.ReadLine().ToLower().Split();

            //foreach (var w in words)
            //{
            //    text = text.Replace(w, new string('*', w.Length));
            //}

            //Console.WriteLine(text);


            ///////////////////////////////////////////////////////////////////////////////////////////////

            //My experiment to censure stupid and brutality words

            ////array of censured words
            //string[] shitWords = new string[] {"pedal", "glupak", "govno", "laino", "sopol", "tup", "ui" };

            ////user input
            //string text = Console.ReadLine().ToLower();

            ////frow which positon to start scan
            //int index = 0;

            ////iterate through array of forbidden words
            //for (int i = 0; i < shitWords.Length; i++)
            //{
            //    //next line search for matches
            //    index = text.IndexOf(shitWords[i]);
            //    string originalWord = shitWords[i];

            //    if (index > -1)  //if find something
            //    {
            //        char letter = shitWords[i][0]; //get the first letter from founded word from array

            //        char lastLetter = shitWords[i][shitWords[i].Length - 1]; //get the last letter ...

            //        //next line just replaces all letters without first and last from founded word with '*'
            //        if (shitWords[i].Length > 2)
            //        {
            //            shitWords[i] = shitWords[i].Replace(shitWords[i], new string('*', shitWords[i].Length - 2));
            //            shitWords[i] = letter + shitWords[i] + lastLetter;
            //        }
            //        else
            //        {
            //            shitWords[i] = shitWords[i].Replace(shitWords[i], new string('*', shitWords[i].Length));
            //            shitWords[i] =  shitWords[i];
            //        }


            //        //just write ther result on console
            //        //Console.WriteLine(letter + shitWords[i] + lastLetter);

            //        //shitWords[i] = letter + shitWords[i] + lastLetter;
            //        Console.WriteLine(shitWords[i]);
            //        text = text.Replace(originalWord, shitWords[i]);
            //        Console.WriteLine(text);




            //        //break;
            //    }

            //}




            //to try write a progam which find word from characters
            //List<string> wordsToFind = new List<string>() {"perrot", "orange", "pray", "milcho", "orange fruit", "parma", "parmalat", "dreamers", "dream", "dre", "dr.dre", "android" };
            //List<string> letters = Console.ReadLine().ToLower().Trim().Split().ToList();
            //List<string> result = new List<string>();




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
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //Console.ReadLine();





            //for (int w = 0; w < letters.Count; w++)
            //{
            //    //pos = wordsToFind.IndexOf(letters[w], pos + 1);
            //    //if (pos > -1)
            //    if (wordsToFind.Contains(letters[w]))
            //    {
            //        result.Add(letters[w]);
            //        //Console.WriteLine(letters[w]);
            //        //break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not found");
            //        break;
            //    }
            //}


            ///////////////////////////////////////////////////////////////////////////////////////////////



            //Super Mario Song
            //Console.Beep(659, 125);
            //Console.Beep(659, 125);
            //Thread.Sleep(125);
            //Console.Beep(659, 125);
            //Thread.Sleep(167);
            //Console.Beep(523, 125);
            //Console.Beep(659, 125);
            //Thread.Sleep(125);
            //Console.Beep(784, 125);
            //Thread.Sleep(375);
            //Console.Beep(392, 125);
            //Thread.Sleep(375);
            //Console.Beep(523, 125);
            //Thread.Sleep(250);
            //Console.Beep(392, 125);
            //Thread.Sleep(250);
            //Console.Beep(330, 125);
            //Thread.Sleep(250);
            //Console.Beep(440, 125);
            //Thread.Sleep(125);
            //Console.Beep(494, 125);
            //Thread.Sleep(125);
            //Console.Beep(466, 125);
            //Thread.Sleep(42);
            //Console.Beep(440, 125);
            //Thread.Sleep(125);
            //Console.Beep(392, 125);
            //Thread.Sleep(125);
            //Console.Beep(659, 125);
            //Thread.Sleep(125);
            //Console.Beep(784, 125);
            //Thread.Sleep(125);
            //Console.Beep(880, 125);
            //Thread.Sleep(125);
            //Console.Beep(698, 125);
            //Console.Beep(784, 125);
            //Thread.Sleep(125);
            //Console.Beep(659, 125);
            //Thread.Sleep(125);
            //Console.Beep(523, 125);
            //Thread.Sleep(125);
            //Console.Beep(587, 125);
            //Console.Beep(494, 125);
            //Thread.Sleep(125);
            //Console.Beep(523, 125);
            //Thread.Sleep(250);
            //Console.Beep(392, 125);
            //Thread.Sleep(250);
            //Console.Beep(330, 125);
            //Thread.Sleep(250);
            //Console.Beep(440, 125);
            //Thread.Sleep(125);
            //Console.Beep(494, 125);
            //Thread.Sleep(125);
            //Console.Beep(466, 125);
            //Thread.Sleep(42);
            //Console.Beep(440, 125);
            //Thread.Sleep(125);
            //Console.Beep(392, 125);
            //Thread.Sleep(125);
            //Console.Beep(659, 125);
            //Thread.Sleep(125);
            //Console.Beep(784, 125);
            //Thread.Sleep(125);
            //Console.Beep(880, 125);
            //Thread.Sleep(125);
            //Console.Beep(698, 125);
            //Console.Beep(784, 125);
            //Thread.Sleep(125);
            //Console.Beep(659, 125);
            //Thread.Sleep(125);
            //Console.Beep(523, 125);
            //Thread.Sleep(125);
            //Console.Beep(587, 125);
            //Console.Beep(494, 125);
            //Thread.Sleep(375);
            //Console.Beep(784, 125);
            //Console.Beep(740, 125);
            //Console.Beep(698, 125);
            //Thread.Sleep(42);
            //Console.Beep(622, 125);
            //Thread.Sleep(125);
            //Console.Beep(659, 125);
            //Thread.Sleep(167);
            //Console.Beep(415, 125);
            //Console.Beep(440, 125);
            //Console.Beep(523, 125);
            //Thread.Sleep(125);
            //Console.Beep(440, 125);
            //Console.Beep(523, 125);
            //Console.Beep(587, 125);
            //Thread.Sleep(250);
            //Console.Beep(784, 125);
            //Console.Beep(740, 125);
            //Console.Beep(698, 125);
            //Thread.Sleep(42);
            //Console.Beep(622, 125);
            //Thread.Sleep(125);
            //Console.Beep(659, 125);
            //Thread.Sleep(167);
            //Console.Beep(698, 125);
            //Thread.Sleep(125);
            //Console.Beep(698, 125);
            //Console.Beep(698, 125);
            //Thread.Sleep(625);
            //Console.Beep(784, 125);
            //Console.Beep(740, 125);
            //Console.Beep(698, 125);
            //Thread.Sleep(42);
            //Console.Beep(622, 125);
            //Thread.Sleep(125);
            //Console.Beep(659, 125);
            //Thread.Sleep(167);
            //Console.Beep(415, 125);
            //Console.Beep(440, 125);
            //Console.Beep(523, 125);
            //Thread.Sleep(125);
            //Console.Beep(440, 125);
            //Console.Beep(523, 125);
            //Console.Beep(587, 125);
            //Thread.Sleep(250);
            //Console.Beep(622, 125);
            //Thread.Sleep(250);
            //Console.Beep(587, 125);
            //Thread.Sleep(250);
            //Console.Beep(523, 125);
            //Thread.Sleep(1125);
            //Console.Beep(784, 125);
            //Console.Beep(740, 125);
            //Console.Beep(698, 125);
            //Thread.Sleep(42);
            //Console.Beep(622, 125);
            //Thread.Sleep(125);
            //Console.Beep(659, 125);
            //Thread.Sleep(167);
            //Console.Beep(415, 125);
            //Console.Beep(440, 125);
            //Console.Beep(523, 125);
            //Thread.Sleep(125);
            //Console.Beep(440, 125);
            //Console.Beep(523, 125);
            //Console.Beep(587, 125);
            //Thread.Sleep(250);
            //Console.Beep(784, 125);
            //Console.Beep(740, 125);
            //Console.Beep(698, 125);
            //Thread.Sleep(42);
            //Console.Beep(622, 125);
            //Thread.Sleep(125);
            //Console.Beep(659, 125);
            //Thread.Sleep(167);
            //Console.Beep(698, 125);
            //Thread.Sleep(125);
            //Console.Beep(698, 125);
            //Console.Beep(698, 125);
            //Thread.Sleep(625);
            //Console.Beep(784, 125);
            //Console.Beep(740, 125);
            //Console.Beep(698, 125);
            //Thread.Sleep(42);
            //Console.Beep(622, 125);
            //Thread.Sleep(125);
            //Console.Beep(659, 125);
            //Thread.Sleep(167);
            //Console.Beep(415, 125);
            //Console.Beep(440, 125);
            //Console.Beep(523, 125);
            //Thread.Sleep(125);
            //Console.Beep(440, 125);
            //Console.Beep(523, 125);
            //Console.Beep(587, 125);
            //Thread.Sleep(250);
            //Console.Beep(622, 125);
            //Thread.Sleep(250);
            //Console.Beep(587, 125);
            //Thread.Sleep(250);
            //Console.Beep(523, 125);



            ///////////////////////////////////////////////////////////////////////////////////////////////

            //Dictionary<string, string> phonebook = new Dictionary<string, string>();
            //phonebook["John Smith"] = "+344 4545 5454";
            //phonebook["Lisa Smith"] = "+344 2347 5667";
            //phonebook["Jo Does"] = "+356 3683 4567";
            //phonebook["Nakov"] = "+359 3455 4567";

            //phonebook["Nakov"] = "+359 2345 1111";
            //phonebook.Remove("Jo Does");


            //foreach (var numbers in phonebook)
            //{
            //    Console.WriteLine($"{numbers.Key} -> {numbers.Value}");
            //}

            ///////////////////////////////////////////////////////////////////////////////////////////////


            //List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            //SortedDictionary<double, int> sortedNums = new SortedDictionary<double, int>();

            //foreach (var num  in numbers)
            //{
            //    if (sortedNums.ContainsKey(num))
            //    {
            //        sortedNums[num]++;
            //    }
            //    else
            //    {
            //        sortedNums[num] = 1;
            //    }
            //}



            //foreach (var item in sortedNums.Keys)
            //{
            //    Console.WriteLine($"{item} -> {sortedNums[item]}");
            //}


            ///////////////////////////////////////////////////////////////////////////////////////////////


            //string[] words = Console.ReadLine().ToLower().Split();
            //Dictionary<string, int> counter = new Dictionary<string, int>();

            //foreach (var w in words)
            //{
            //    if (counter.ContainsKey(w))
            //    {
            //        counter[w]++;
            //    }
            //    else
            //    {
            //        counter[w] = 1;
            //    }
            //}


            //List<string> result = new List<string>();

            //foreach (var item in counter)
            //{
            //    if (item.Value % 2 != 0)
            //    {
            //        result.Add(item.Key);
            //    }
            //}

            //Console.WriteLine(string.Join(", ", result));


            ///////////////////////////////////////////////////////////////////////////////////////////////




        }
    }
}
