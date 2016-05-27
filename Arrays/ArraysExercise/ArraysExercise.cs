using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExercise
{
    class ArraysExercise
    {
        static void Main(string[] args)
        {
            //string[] days =
            //{
            //    "Monday",
            //    "Tuesday",
            //    "Wednesday",
            //    "Thursday",
            //    "Friday",
            //    "Saturday",
            //    "Sunday"
            //};

            //Първият елемент променяме по следния начин
            //days[0] = "Понеделник е първият елемент";

            //проненяме стойността на последния елемент по следния начин
            //days[days.Length - 1] = "Петък е посленият елемент в масива";

            //for (int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}



            ////////////////////////////////////////////////////////////////////////

            //string[] days = new string[7];
            //days[0] = "Понеделник";
            //days[1] = "Вторник";
            //days[2] = "Сряда";
            //days[3] = "Четвъртък";
            //days[4] = "Петък";
            //days[5] = "Събота";
            //days[6] = "Неделя";

            //for (int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}

            ////////////////////////////////////////////////////////////////////////


            //string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            //int day = int.Parse(Console.ReadLine());
            //if(day >= 1 && day <= 7)
            //{
            //    Console.WriteLine(days[day - 1]);
            //}else
            //{
            //    Console.WriteLine("Invalid day");
            //}

            ////////////////////////////////////////////////////////////////////////

            //Sieve of Erathosten - Решение на Ератостен за намиране на прости числа

            //int n = int.Parse(Console.ReadLine());

            //Създава булев масив с елементи до n + 1 , защото примерно ако елементите са 5 , int[] n = new int[5], ще създаде масив с елементи от 0 до 4 и няма да успеем да проверим n-я елемент.
            //bool[] primes = new bool[n + 1];


            //Всички числа след две по подразбиране ги приемаме за прости
            //for (int i = 2; i <= n; i++)
            //{
            //    primes[i] = true;
            //}


            //for (int num = 2; num <= n; num++)
            //{
            //Aко числото на позиция num е просто, тогава първо го изписваме на конзолата и след това увеличаваме стъпката за проверка със следващото по-голямо от num число, което се дели на num. Примерно ако num e било 2, ще задраска 4, 6, ,8, 10.....
            //if(primes[num])
            //{
            //    Console.WriteLine(num);
            //    var step = 2 * num;

            //Въртим цикълът while докато стъпката е по-малка или равна на входното число n, и задраскваме чрез primes[step] = false; 
            //while (step <= n)
            //{
            //    primes[step] = false;
            //    step += num;
            //}

            //    }
            //}


            ////////////////////////////////////////////////////////////////////////

            //Problem Last K Numbers Sums


            //int n = int.Parse(Console.ReadLine());
            //int k = int.Parse(Console.ReadLine());

            //Заделяме масив от n числа за редицата
            //long[] nums = new long[n];
            //nums[0] = 1;

            //for (int i = 1; i < n; i++)
            //{
            //    long sum = 0;


            //    for (int prev = i - k; prev <= i - 1; prev++)
            //    {
            //        if(prev >= 0)
            //        {
            //            sum += nums[prev];

            //        }

            //        nums[i] = sum;

            //    }

            //}


            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(nums[i] + " ");
            //}



            //int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //foreach (int digits in nums)
            //{
            //    Console.WriteLine(digits);
            //}






            //int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int[] secondPart = new int[nums.Length];
            //nums.CopyTo(secondPart, 0);
            //Console.WriteLine(string.Join(" ", secondPart));

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("#");
            //    Console.Write(new string('~', i));
            //    Console.Write("#");
            //    Console.Write(new string('.', 2 * n - 2 * i));
            //    Console.Write("#");
            //    Console.Write(new string('.', 2 * i));
            //    Console.Write("#");
            //    Console.Write(new string('.', 2 * n - 2 * i));
            //    Console.Write("#");
            //    Console.Write(new string('~', i));
            //    Console.WriteLine("#");
            //}




        }
    }
}
