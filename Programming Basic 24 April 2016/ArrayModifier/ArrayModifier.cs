using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayModifier
{
    class ArrayModifier
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] actions = command.Split(' ').ToArray();
                if (actions.Length > 1)
                {
                    long pos1 = long.Parse(actions[1]);
                    long pos2 = long.Parse(actions[2]);

                    if (actions[0] == "swap")
                    {
                        long temp = numbers[pos1];
                        numbers[pos1] = numbers[pos2];
                        numbers[pos2] = temp;

                        //foreach (var item in numbers)
                        //{
                        //    Console.Write(item + " ");
                        //}

                    }
                    else if (actions[0] == "multiply")
                    {
                        numbers[pos1] = numbers[pos1] * numbers[pos2];

                        //foreach (var item in numbers)
                        //{
                        //    Console.Write(item + " ");
                        //}
                    }
                    
                }

                if (actions[0] == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i]--;

                        //foreach (var item in numbers)
                        //{
                        //    Console.Write(item + " ");
                        //}
                    }
                }


                command = Console.ReadLine();

            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
