using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] lettersOne = Console.ReadLine().ToCharArray();
            char[] lettersTwo = Console.ReadLine().ToCharArray();

            int bigger = Math.Max(lettersOne.Length, lettersTwo.Length);
            int minimum = Math.Min(lettersOne.Length, lettersTwo.Length);


            //if (lettersOne.Length == lettersTwo.Length)
            //{
            //    if (lettersOne[0] < lettersTwo[0])
            //    {
            //        Console.WriteLine(string.Join("", lettersOne));
            //        Console.WriteLine(string.Join("", lettersTwo));
            //    }
            //    else
            //    {
            //        Console.WriteLine(string.Join("", lettersTwo));
            //        Console.WriteLine(string.Join("", lettersOne));
            //    }
            //}



            for (int a = 0; a < lettersOne.Length; a++)
            {
                for (int b = 0; b < lettersTwo.Length; b++)
                {
                    if (lettersOne[a] == lettersTwo[b] && a < lettersOne.Length - 1)
                    {
                        //да проверя дължините
                    }
                }
            }



            //int count = 0;
            //while (lettersOne[count] != lettersTwo[count] || count ==  bigger)
            //{

            //    count++;
            //}
            //for (int i = 0; i < bigger; i++)
            //{
            //    if (lettersOne[i] < lettersTwo[i])
            //    {
            //        Console.Write(lettersTwo[i] + " ");
            //    }
            //}



        }
    }
}
