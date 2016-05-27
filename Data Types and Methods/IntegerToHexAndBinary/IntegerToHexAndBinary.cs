using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());

            Console.WriteLine("{0:X}", (int)number);

            int numberConv = (int)number;
            Console.WriteLine("{0}", Convert.ToString(numberConv, 2).ToUpper());
           
        }
    }
}
