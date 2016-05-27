using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class LargestCommonEnd
    {

        static int LargCommonEnd(string[] wordsOne, string[] wordsTwo)
        {
            var rightCount = 0;
            while (rightCount < wordsOne.Length && rightCount < wordsTwo.Length)
            {
                if (wordsOne[wordsOne.Length - rightCount - 1] == wordsTwo[wordsTwo.Length - rightCount - 1])
                {
                    rightCount++;
                }
                else
                {
                    break;
                }
            }

            //return rightCount;


            var leftCount = 0;
            while (leftCount < wordsOne.Length && leftCount < wordsTwo.Length)
            {
                if (wordsOne[leftCount] == wordsTwo[leftCount])
                {
                    leftCount++;
                }
                else
                {
                    break;
                }
            }

            //return leftCount;


            if (rightCount < leftCount)
            {
                return leftCount;
            }
            else
            {
                return rightCount;
            }

        }





        static void Main(string[] args)
        {
            string[] wordsOne = Console.ReadLine().Split(' ').ToArray();
            string[] wordsTwo = Console.ReadLine().Split(' ').ToArray();

            Console.WriteLine(LargCommonEnd(wordsOne, wordsTwo));

        }
    }
}
