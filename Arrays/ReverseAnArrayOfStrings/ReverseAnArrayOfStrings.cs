using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArrayOfStrings
{
    class ReverseAnArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            //works
            //words = words.Reverse().ToArray();
            //Console.WriteLine(string.Join(" ", words));

            for (int i = 0; i < words.Length / 2; i++)
            {
                string temp = words[i];
                words[i] = words[words.Length - 1 - i];
                words[words.Length - 1 - i] = temp;
            }

            Console.WriteLine(string.Join(" ", words));

        }
    }
}
