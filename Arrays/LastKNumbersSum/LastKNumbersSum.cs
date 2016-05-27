using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSum
{
    class LastKNumbersSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());


            //Заделяме нов масив с дължина n
            long[] sequences = new long[n];

            //На първият елемент от масива му присвояваме стойност 1 , защото ако остане 0, сумата на елементите ще бъде също 0 
            sequences[0] = 1;

            //Тук започваме от 1, защото 1 е вторият елемент от масива и въртим докато i e по-малка от n
            for (int i = 1; i < n; i++)
            {
                long sum = 0;

                //Тук задаваме началната точка на числовата редица от къде да започне, а след това задаваме също и крайната точка -> i - 1
                for (int previous = i - k; previous <= i - 1; previous++)
                {
                    if (previous >= 0)
                    {
                        sum += sequences[previous];
                    }

                    sequences[i] = sum;

                }

            }


            for (int i = 0; i < n; i++)
            {
                Console.Write(sequences[i] + " ");
            }



        }
    }
}
