using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceEqualElements
{
    class MaxSequenceEqualElements
    {
        static void Main(string[] args)
        {
            //раздробявам въведения низ на масив от числа
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //правя стрингова променлива, в която ще добавям поредицата числа
            string seq = string.Empty;


            int number = 0;     //в тази променлива ще държа повтарящото се число от серийката
            int sequence = 0;   //тук ще държа най-голямата намерена поредица от числа
            int currentSequence = 0;    //тук ще държа моментната поредица от числа, която ще сравнявам със                         sequence

            for (int i = 1; i <= numbers.Length - 1; i++)   //започвам да въртя цикъл, за да обходя масива                                               с числата.
            {
                if (numbers[i - 1] == numbers[i])   //сравнявам числото от ляво с това от дясно и ако са                                       равни увеличавам променливата , която съдържа                                             текущата поредица от числа. 
                {
                    currentSequence++;
                    
                }
                else                            //ако не са равни числата просто занулявам моментната                                      поредица , за да започне да брои отначало.
                {
                    currentSequence = 0;
                }

                if (currentSequence > sequence)     //и накрая просто сравнявам моментната поредица с най-голямата, която съм намерил преди нея и ако сегашната поредица е по-голяма от миналата, то на променливата съдържаща миналата поредица и предавам новата най-голяма такава.
                {
                    sequence = currentSequence;
                    number = numbers[i];            //Тук записвам повтарящото се число от поредицата.
                    
                }
               
            }

            //тук въртя цикъл от 0 до намерената поредица, тоест обхождам си я и към стринговата променлива просто добавям намереното по-горе число.
            for (int i = 0; i <= sequence; i++)
            {
                seq += number + " ";
            }

            Console.WriteLine(seq);   //просто изписвам стринговата променлива с намерената поредица
        }
    }
}
