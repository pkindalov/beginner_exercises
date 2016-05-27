using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Diagnostics;

namespace WorkInClass
{
    class WorkInClass
    {
        static void Main(string[] args)
        {
            //DateTime peshoBirth = new DateTime(1996, 11 , 27);
            //Console.WriteLine(peshoBirth);

            //DateTime mariaBirth = new DateTime(2002, 12, 12);
            //Console.WriteLine(mariaBirth);

            //var mariaAfter18Months = mariaBirth.AddMonths(18);
            //Console.WriteLine(mariaAfter18Months);

            //Console.WriteLine(mariaAfter18Months.Day);

            ////Timespan - връща продължителност
            //var diff = mariaBirth - peshoBirth;
            //Console.WriteLine(diff.TotalHours);


            ////////////////////////////////////////////////////////////////////////////////////////////

            //Day of week
            //var dateElements = Console.ReadLine().Split('-').Select(int.Parse).ToArray();

            //var date = new DateTime(dateElements[2], dateElements[1], dateElements[0]);
            //Console.WriteLine(date.DayOfWeek);



            //Console.WriteLine(string.Format(new Cultureinfo("tr-TR"), "0:d-MMM-yyyy"date);

            //////////////////////////////////////////////////////////////////////////////////////////


            //Randomize Words

            //var words = Console.ReadLine().Split(' ').ToList();
            //Random rnd = new Random();

            //var result = new List<string>();

            //while (words.Count > 0)
            //{
            //    var pos = rnd.Next(0, words.Count);
            //    result.Add(words[pos]);
            //    words.RemoveAt(pos);
            //}


            //Console.WriteLine(string.Join("\r\n", result));





            //Problem Big Factoriel

            //var n = int.Parse(Console.ReadLine());
            //BigInteger fact = 1;

            //for (int i = 2; i <= n; i++)
            //{
            //    fact *= i;
            //}

            //Console.WriteLine(fact);


            ////////////////////////////////////////////////////////////////////////////////////////////

            WebClient webclient = new WebClient();
            webclient.DownloadFile("http://www.introprogramming.info/wp-content/uploads/2015/10/Intro-CSharp-Book-v2015.pdf", "book.pdf");
            Process.Start("book.pdf");

            

            
        }
    }
}
