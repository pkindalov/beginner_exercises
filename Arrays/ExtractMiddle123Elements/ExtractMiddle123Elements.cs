using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMiddle123Elements
{
    class ExtractMiddle123Elements
    {

        static string ExtractMiddle(int[] numbers)
        {
            string n = string.Empty;

            if (numbers.Length == 1)
            {
                n = "{" + " " + numbers[0] + " " + "}";
            }
            else if ((numbers.Length % 2) == 0)
            {
                int startIndex = (numbers.Length / 2) - 1;
                int endIndex = (numbers.Length / 2);

                for (int i = startIndex; i <= endIndex; i++)
                {
                    n += "{" + " " + numbers[i] + " " + "}";
                }
                

            }
            else
            {
                int startIndex = (numbers.Length / 2) - 1;
                int endIndex = (numbers.Length / 2) + 1;

                for (int i = startIndex; i <= endIndex; i++)
                {
                    n += "{" + " " + numbers[i] + " " + "}";
                }


            }



            return n;
        }






        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(ExtractMiddle(numbers));
        }
    }
}
