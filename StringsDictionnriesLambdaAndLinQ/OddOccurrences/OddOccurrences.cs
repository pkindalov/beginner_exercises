using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            //Правим масив , който да съдържа всички думи като преди това сме ги направили да са с малки букви
            string[] words = Console.ReadLine().ToLower().Split(' ').ToArray();


            //Правим речник с ключ от тип низ и стойност от тип цяло число. Ключът ще съдържа думите, а цялото число представлява брояча и ще показва колко пъти се среща тази дума.
            var count = new Dictionary<string, int>();


            //Обхождаме всички думи от масива words
            foreach (var w in words)
            {

                //Проверяваме дали текущата дума я има в ключовите стойности на речника
                if (count.ContainsKey(w))             //и ако я има
                {
                    count[w]++;                      //просто увеличаваме бройката и
                }
                else                                //ако я няма 
                {
                    count[w] = 1;                   //на тази позиция в брояча даваме стойност 1
                }


            }


            var result = new List<string>();            //Правим лист от тип низ за резултатите 



            foreach (var pair in count)                 //Обхождаме брояча, за да видим коя дума колко                                              пъти се среща
            {
                if ((pair.Value % 2) != 0)              //Ако стойността на речника count бъде нечетна
                {
                    result.Add(pair.Key);               //Тогава добавяме стойността към резултатния                                        лист(списък)
                }

            }

            Console.WriteLine(string.Join(" ", result));        //Просто изписваме резултата


        }
    }
}
