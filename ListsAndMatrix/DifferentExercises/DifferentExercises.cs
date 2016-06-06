using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentExercises
{
    class DifferentExercises
    {
        static void Main(string[] args)
        {
            //Remove Negatives and Reverse
            //List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            //List<int> positiveNumbers = new List<int>();

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] >= 0)
            //    {
            //        positiveNumbers.Add(numbers[i]);
            //    }
            //}

            //if (positiveNumbers.Count > 0)
            //{
            //    positiveNumbers.Reverse();
            //    Console.WriteLine(string.Join(" ", positiveNumbers));
            //}
            //else
            //{
            //    Console.WriteLine("empty");
            //}


            ///////////////////////////////////////////////////////////////////////////////////////////////


            //Append Lists

            //List<int> numbers = Console.ReadLine().Split(new char[] { '|', ' ' },        StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            //List<string> numbers = Console.ReadLine().Split('|').ToList();
            //List<string> result = new List<string>();

            //for (int i = numbers.Count - 1; i >= 0; i--)
            //{
            //    string[] words = numbers[i].Split();

            //    foreach (var item in words)
            //    {
            //        if (item != "")
            //        {
            //            result.Add(item);
            //        }
            //    }   

            //}


            //Console.WriteLine(string.Join(" ", result));


            //int[] input = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

            //List<int> temp = new List<int>();
            //List<int> result = new List<int>();

            //temp.Add(input[0]);   //Добавяме първия елемент от масива input в листа temp.
            //for (int i = 1; i < input.Length; i++) //Започваме да обхождаме масива input
            //{
            //    if (input[i] == input[i - 1])  //Сравнява текущия и миналия елемент 
            //    {
            //        temp.Add(input[i]);         //Ако намери съвпадение добавя текущия елемент във                                  времения списък
            //        if (i == input.Length - 1)  //Когато стигнем последния елемент от масива input                                правим същата проверка като в елзе - тоест проверяваме бройката елементи от времения списък temp дали е по-голяма от броят елементи в листа result, тоест ако в temp има повече резултати от листа result, последният се изчиства и след това му се добавят резултатите от листа temp.
            //        {
            //            if (temp.Count > result.Count)
            //            {
            //                result.Clear();
            //                result.InsertRange(0, temp);
            //            }
            //        }
            //    }
            //    else                                     //Ако текущия и миналия елемент са различни
            //    {
            //        if (temp.Count > result.Count)      //Проверяваме дали намерените резултати във                                     времения лист са повече от този на result. Ако                                    темп има повече намерени елементи, тоест поредица                                 от числа тогава изчистваме листа result и му                                      даваме намерената поредица числа от temp 
            //        {
            //            result.Clear();
            //            result.InsertRange(0, temp);
            //        }
            //        temp.Clear();                   //След като сме предали поредицата от числа от temp                               на result , изчистваме temp и след това му предаваме                              текущия елемент. 
            //        temp.Add(input[i]);
            //    }
            //}


            //Console.WriteLine("{0}", string.Join(" ", result));


            ///////////////////////////////////////////////////////////////////////////////////////////////












        }
    }
}
