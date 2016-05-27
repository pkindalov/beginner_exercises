using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReversedOrder
{
    class NumbersInReversedOrder
    {
        static void Main(string[] args)
        {

            string num = Console.ReadLine();
            string reverse = "";
            for (int i = num.Length - 1; i >= 0; i--)
            {
                reverse += num[i];
                //Console.Write("{0}", num[i]);
            }
            Console.WriteLine(reverse);

        }
    }
}
