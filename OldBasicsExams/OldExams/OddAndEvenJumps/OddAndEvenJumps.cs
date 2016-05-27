using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAndEvenJumps
{
    class OddAndEvenJumps
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().ToLower().Split(' ').ToArray();
            string input2 = string.Join("", inputs);
            int oddJump = int.Parse(Console.ReadLine());
            int evenJump = int.Parse(Console.ReadLine());

            

            string oddLetters = string.Empty;
            string evenLetters = string.Empty;
            ulong oddSum = 0;
            ulong evenSum = 0;
            int counter = 0;
            int evenCounter = 0;

            //Обхожда думите от масива
            for (int i = 0; i < input2.Length; i++)
            {
                //Обхожда всяка буква от думата в масива
                
                    if ((i % 2) == 0)
                    {
                        oddLetters += input2[i];
                    }
                    else
                    {
                        evenLetters += input2[i];
                    }
                

            }



            //odds sum
            for (int i = 0; i < oddLetters.Length; i++)
            {
                counter++;
                if ((counter % oddJump) == 0)
                {
                    oddSum *= oddLetters[i];
                }
                else
                {
                    oddSum += oddLetters[i];
                }

            }


            //even sum
            for (int c = 0; c < evenLetters.Length; c++)
            {
                evenCounter++;
                if ((evenCounter % evenJump) == 0 )
                {
                    evenSum *= evenLetters[c];
                }
                else
                {
                    evenSum += evenLetters[c];
                }
            }


            //Convert to Hex
            string oddSumHex = oddSum.ToString("x").ToUpper();
            string evenSumHex = evenSum.ToString("x").ToUpper();
            Console.WriteLine(string.Format("Odd: {0:X}", oddSumHex));
            Console.WriteLine(string.Format("Even: {0:X}", evenSumHex));


            //Console.WriteLine(oddLetters);
            //Console.WriteLine(evenLetters);
            //Console.WriteLine("{0:X}", oddSum);
            //Console.WriteLine("{0:X}", evenSum);



            

        }
    }
}
