using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqual_Numbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {

            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> result = new List<double>();

            int pos = 0;

            while (pos < numbers.Count - 1)
            {
                if (numbers[pos] == numbers[pos + 1])
                {
                    numbers[pos] = (numbers[pos] + numbers[pos + 1]);
                    //result.Insert(pos, (numbers[pos] + numbers[pos + 1]));
                    numbers.RemoveAt(pos + 1);
                    pos--;
                    if(pos < 0)
                    {
                        pos = 0;
                    }
                }else
                {
                    pos++;
                }
            }


            foreach (var r in numbers)
            {
                Console.WriteLine(r);
            }

            //foreach (var r in numbers)
            //{
            //    Console.WriteLine(r);
            //}


        }
    }
}
