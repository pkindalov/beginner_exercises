using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            //Първи начин - най-лесен - използва вградена функционалност в езика C#
            //Array.Reverse(numbers);
            //foreach (var nums in numbers)
            //{
            //    Console.WriteLine(nums);
            //}


            //Втори начин - просто чете масива отзад-напред
            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //Трети начин - разменя елементите -> ПЪРВИЯТ С ПОСЛЕНИЯ, ВТОРИЯ С ПРЕДПОСЛЕДНИЯ и така. 

            //for (int i = 0; i < numbers.Length / 2; i++)
            //{
            //    var oldValue = numbers[i];
            //    numbers[i] = numbers[numbers.Length - i - 1];
            //    numbers[numbers.Length - i - 1] = oldValue;

            //}


            //foreach (var nums in numbers)
            //{
            //    Console.WriteLine(nums);
            //}






            //Четвърти начин - като предния , но се използва string.Join();
            //for (int i = 0; i < numbers.Length / 2; i++)
            //{
            //    var oldValue = numbers[i];
            //    numbers[i] = numbers[numbers.Length - i - 1];
            //    numbers[numbers.Length - i - 1] = oldValue;

            //}


            //Console.WriteLine(string.Join(" ", numbers));





        }
    }
}
