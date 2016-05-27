using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishNameOfTheLastDigit
{
    class EnglishNameOfTheLastDigit
    {
        static void Main(string[] args)
        {

            string num = Console.ReadLine();

            string numberName = numName(num);

            Console.WriteLine(numberName);

        }



        static string numName(string num)
        {
            string name = string.Empty;
            num = Convert.ToString(num[num.Length - 1]);
            

            switch (num)
            {
                case "0":
                    name = "zero";
                    break;
                case "1":
                    name = "one";
                    break;
                case "2":
                    name = "two";
                    break;
                case "3":
                    name = "three";
                    break;
                case "4":
                    name = "four";
                    break;
                case "5":
                    name = "five";
                    break;
                case "6":
                    name = "six";
                    break;
                case "7":
                    name = "seven";
                    break;
                case "8":
                    name = "eight";
                    break;
                case "9":
                    name = "nine";
                    break;
                default:
                    break;
            }

            return name;
        }
    }
}
