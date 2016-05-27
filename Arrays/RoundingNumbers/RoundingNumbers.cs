using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();


            for (int i = 0; i < numbers.Length; i++)
            {
                //int rounded = 0;

                //if (numbers[i] < 0)
                //{
                //    rounded = (int)(numbers[i] - 0.5);
                //}
                //else
                //{
                //    rounded = (int)(numbers[i] + 0.5);
                //}


                int rounded = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);


                //ДА НЕ ПРАВЯ ТОВА, НО ДА ЗНАМ ЧЕ СЪЩЕСТВУВА.. ТЕРНАРЕН ОПЕРАТОР
                //int rounded = (numbers[i] < 0 ? 
                //    (int)(numbers[i] - 0.5) 
                //    : 
                //    (int)(numbers[i] + 0.5));

                //int rounded = (numbers[i] < 0 ?(int)(numbers[i] - 0.5):(int)(numbers[i] + 0.5));

                Console.WriteLine("{0} => {1}", numbers[i], rounded);
            }


        }
    }
}
