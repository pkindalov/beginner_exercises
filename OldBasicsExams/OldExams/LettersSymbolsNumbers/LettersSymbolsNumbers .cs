using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersSymbolsNumbers
{
    class LettersSymbolsNumbers
    {
        static decimal letterSum(string text)
        {
            decimal sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];

                if (char.IsLetter(letter))
                {
                    if (char.IsLower(letter))
                    {
                        sum += ((decimal)letter - 96) * 10;
                    }
                    else
                    {
                        sum += ((decimal)letter - 64) * 10;
                    }
                }

                
            }
            return sum;

        }



        static decimal symbols(string text)
        {
            decimal sum = 0;
            decimal count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];

                if (symbol != ' ' &&  !char.IsLetter(symbol) && !char.IsNumber(symbol))
                {
                    count++;
                   
                }
            }

            sum += count * 200;
            return sum;
        }




        static decimal numberCalc(string text)
        {
            decimal sumNumbers = 0;
            decimal result = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];

                if (char.IsNumber(symbol))
                {
                    sumNumbers += (decimal)char.GetNumericValue(symbol);
                }

            }

            result = sumNumbers * 20;
            return result;


        }





        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal lettersSum = 0;
            decimal symbolsSum = 0;
            decimal numbersCount = 0;

            for (int i = 0; i < n; i++)
            {
                string sentences = Console.ReadLine();

                lettersSum   += letterSum(sentences);
                numbersCount += numberCalc(sentences);
                symbolsSum   += symbols(sentences);
               

            }

            Console.WriteLine("{0}", lettersSum);
            Console.WriteLine("{0}", numbersCount);
            Console.WriteLine("{0}", symbolsSum);
        }
    }
}
