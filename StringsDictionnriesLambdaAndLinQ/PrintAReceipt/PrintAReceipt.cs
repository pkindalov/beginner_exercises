using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAReceipt
{
    class PrintAReceipt
    {
        static void Main(string[] args)
        {

            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double sum = 0.0;

            Console.Write("/" + new string('-', 22) + "\\");
            Console.WriteLine();

            //foreach (var rows in numbers)
            //{
            //    Console.WriteLine("| {0,20:F2} |", rows);
            //    sum += rows;
            //}

            for (int row = 0; row < numbers.Length; row++)
            {
                Console.WriteLine("| {0,20:F2} |", numbers[row]);
                sum += numbers[row];
            }




            Console.Write("|" + new string('-', 22) + "|");
            Console.WriteLine();

            Console.Write("| Total: {0,13:F2} |", sum);
            Console.WriteLine();
            Console.Write("\\" + new string('-', 22) + "/");
            Console.WriteLine();

        }
    }
}
