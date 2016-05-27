using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace WorkInClass
{
    class WorkInClass
    {
        static void Main(string[] args)
        {

            //string str = Console.ReadLine();

            //for (int i = 0; i < str.Length; i++)
            //{
            //    // Console.WriteLine(str[i]);
            //    Console.WriteLine($"{str[{0}]} - '{str[i]}'");
            //}


            ////////////////////////////////////////////////////////////////////////////////////////
            //string str = Console.ReadLine().ToLower();

            //int[] count = new int[char.MaxValue];
            //foreach (var letter in str)
            //{
            //    count[letter]++;
            //}

            //for (int i = 0; i < count.Length; i++)
            //{
            //    if (count[i] > 0)
            //    {
            //        var letter = (char)i;
            //        var occur = count[i];
            //        Console.WriteLine("{0} -> {1}", letter, occur);
            //    }

            //}
            ///////////////////////////////////////////////////////////////////////////////////////////



            //string format
            //System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            //int x = 42;

            //Console.WriteLine(x.ToString("X"));

            //var str = string.Format("Числото: {0:C}", x);
            //Console.WriteLine(str);

            //Console.WriteLine("{0:d.mm.yyy HH:mm:ss}", DateTime.Now);



            ///////////////////////////////////////////////////////////////////////////////////////////

            //Print a Receipt

            //var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            //Console.WriteLine(@"/----------------------------\");

            //foreach (var num in nums)
            //{
            //    Console.WriteLine("| {0,21:f2} |", num);

            //}
            //Console.WriteLine("----------------------------");
            //Console.WriteLine(" | Total: {0,21:f2);


            ////////////////////////////////////////////////////////////////////////////////////////


            //string str = Console.ReadLine().ToLower();
            //string pattern = Console.ReadLine();
            //var count = 0;
            //var pos = 0;

            //while (true)
            //{
            //    pos = str.IndexOf(pattern, pos);
            //    if (pos == -1) break;
            //    count++;
            //    pos += 1;
            //}

            //Console.WriteLine(count);


            ///////////////////////////////////////////////////////////////////////////////////////

            //string str = Console.ReadLine();
            //string[] word = Console.ReadLine().Split(' ');

            //foreach (var w in word)
            //{
            //    str = str.Replace(w, new string('*', w.Le));
            //}

            //////////////////////////////////////////////////////////////////////////////////////////




            // Console.WriteLine("{0:d.MM.yyy}", DateTime.Now);

            //string template = "d.MM.yyyy";
            //string date = string.Format("{0}", DateTime.ParseExact(template, DateTime.Now, provider));
            //Console.WriteLine(date);


            //string date = DateTime.Now.ToString();
            //string format = "d.MM.yyyy";

            //string result = Convert.ToString(DateTime.ParseExact(date, format, CultureInfo.InvariantCulture));
            //Console.WriteLine(result);

            ////////////////////////////////////////////////////////////////////////////////////////////

            //string text = Console.ReadLine();
            //string[] words = Console.ReadLine().Split(' ').ToArray();

            //foreach (string w in words)
            //{
            //    text = text.Replace(w, new string('*', w.Length));

            //}

            //Console.WriteLine(text);


            ////////////////////////////////////////////////////////////////////////////////////////////


            //var phonebook = new Dictionary<string, string>();

            //phonebook["John Smith"] = "+359 4353456";
            //phonebook["Lisa Smith"] = "+359 3456576";
            //phonebook["Sam Doe"] = "+359 5324256";
            //phonebook["Nakov"] = "+359 342312";
            //phonebook["Nakov"] = "+359 765321";

            //phonebook.Remove("John Smith");

            //foreach (var names in phonebook)
            //{
            //    Console.WriteLine("{0} -> {1}", names.Key, names.Value);
            //}



            ///////////////////////////////////////////////////////////////////////////////////////////
            /// LINQ /////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////

            //var count = "some text"
            //.Where(c => !char.IsLetter(c))
            //.Count();

            //Console.WriteLine(count);


            //int[] arr = new int[] { 10, 30, 50, 20 , 40 };
            //Console.WriteLine(arr.Sum());
            //Console.WriteLine(arr.Max());
            //Console.WriteLine(arr.Last());
            //Console.WriteLine(arr.Skip(3).First());
            //Console.WriteLine(arr.Skip(1).Take(3).Min());


            //var numbers = new int[]{20, 49, 45, 32, 21, 56}.Where(x => x > 25).Where(x => (x % 2) == 0).OrderBy(x => x);
            //Console.WriteLine(string.Join(" ", numbers));


            var otherNumbers = new int[] { 11, 99, 33, 55, 77, 44, 66, 22, 88 }
            .Where((x, pos) => pos % 2 == 1).OrderBy(x => x).Take(3);

            Console.WriteLine(string.Join(" ", otherNumbers));

        }
    }
}
