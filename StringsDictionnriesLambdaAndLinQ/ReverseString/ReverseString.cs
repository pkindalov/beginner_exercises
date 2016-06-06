using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            //string text = Console.ReadLine();
            //for (int i = text.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(text[i]);
            //}
            //Console.WriteLine();

            string word = Console.ReadLine();
            char[] letters = word.ToCharArray();

            Array.Reverse(letters);

            foreach (var item in letters)
            {
                Console.Write(string.Join(" ", item));
            }
            Console.WriteLine();
            
        }
    }
}
