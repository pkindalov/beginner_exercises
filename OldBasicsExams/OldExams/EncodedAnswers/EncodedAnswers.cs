using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodedAnswers
{
    class EncodedAnswers
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            long answerA = 0;
            long answerB = 0;
            long answerC = 0;
            long answerD = 0;
            string letters = null;

            for (long i = 0; i < n; i++)
            {
                long number = long.Parse(Console.ReadLine());

                if ((number % 4) == 0)
                {
                    letters += "a ";
                    answerA++;
                }else if((number % 4) == 1)
                {
                    letters += "b ";
                    answerB++;
                }else if((number % 4) == 2)
                {
                    letters += "c ";
                    answerC++;
                }else if((number % 4) == 3)
                {
                    letters += "d ";
                    answerD++;
                }
            }

            Console.WriteLine(letters);
            Console.WriteLine("Answer A: {0}", answerA);
            Console.WriteLine("Answer B: {0}", answerB);
            Console.WriteLine("Answer C: {0}", answerC);
            Console.WriteLine("Answer D: {0}", answerD);
        }
    }
}
