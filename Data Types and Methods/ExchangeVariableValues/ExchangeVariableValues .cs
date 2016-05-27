using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 5;
            byte b = 10;
            byte temp = 0;

            Console.WriteLine("Before: ");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            Console.WriteLine("After: ");
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}
