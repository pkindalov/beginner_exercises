using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensorYourEmailAddress
{
    class CensorYourEmailAddress
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            string[] mail = input.Split('@');

            string replace = mail[0].Replace(mail[0], new string('*', mail[0].Length)) + "@" + mail[1];
            output = output.Replace(input, replace);
            Console.WriteLine(output);



        }
    }
}
