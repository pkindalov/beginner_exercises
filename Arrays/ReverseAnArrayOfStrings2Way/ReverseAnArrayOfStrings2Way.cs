using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArrayOfStrings2Way
{
    class ReverseAnArrayOfStrings2Way
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            words = words.Reverse().ToArray();
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
