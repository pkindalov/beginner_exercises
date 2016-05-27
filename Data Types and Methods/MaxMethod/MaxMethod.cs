using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod
{
    class MaxMethod
    {

        static int GetMax(int num1, int num2)
        {
            int bigger = Math.Max(num1, num2);
            return bigger;
        }


        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int biggNumFromNum1and2 = GetMax(num1, num2);

            Console.WriteLine(Math.Max(num3, biggNumFromNum1and2));

        }

        
    }
}
