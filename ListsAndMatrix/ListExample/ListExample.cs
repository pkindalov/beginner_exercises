using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    class ListExample
    {
        static void Main(string[] args)
        {
            //List<string> names = new List<string>();
            //names.Add("Pesho");
            //names.Add("Kiro");
            //names.Add("Maria");
            //names.Add("Ivan");

            //names.Insert(2, "Нов чиляк");

            //names.Remove("Kiro");

            //Console.WriteLine(string.Join(", ", names));

            //names.RemoveAt(2);
            //Console.WriteLine(string.Join(", ", names));



            //foreach (var name in names)
            //{
            //    //Console.WriteLine(name);
            //    Console.WriteLine(string.Join(", ", names));
            //}




            ////// Упражнения //////////////////////////////////////////////////////////////////////
            //List<string> names = new List<string>()
            //{"Росен", "Иван", "Мария", "Гошо", "Спас", "Пешо" };


            //Console.WriteLine(names.Count);

            //foreach (var name in names)
            //{
            //    Console.Write(string.Join(" ", names));
            //    Console.WriteLine();
            //}
            ////names.Remove("Росен");
            //names.RemoveAt(1);
            //names.Insert(1, "Милчо");
            //names.Add("Панайот");

            //foreach (var name in names)
            //{
            //    Console.Write(string.Join(" ", names));
            //    Console.WriteLine();
            //}

            //Console.WriteLine(names.Count);

            //Console.WriteLine(names[names.Count - 1]);







            //Read a list of integers, remove all negative numbers from it and print the list in reversed order:


            //List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //List<int> result = new List<int>();


            //foreach (var n in numbers)
            //{

            //    if (n >= 0)
            //    {
            //        result.Add(n);
            //    }

            //}


            //Първи начин -> просто четем листа отзад-напред
            //for (int i = result.Count - 1; i >= 0; i--)
            //{
            //    Console.Write(result[i] + " ");
            //}



            //Втори начин -> Използваме вградена функционалност(Reverse) и след това просто прочитаме листа
            // result.Reverse();

            //foreach (var nums in result)
            //{
            //    Console.Write(nums + " ");
            //}


            //if (result.Count > 0)
            //{
            //    Console.WriteLine(string.Join(" ", result));
            //}else
            //{
            //    Console.WriteLine("empty");
            //}






            //Append List
            //List<string> n = Console.ReadLine().Split('|').ToList();
            //List<string> result = new List<string>();

            //for (int i = n.Count - 1; i >= 0; i--)
            //{
            //    string[] noSpaces = n[i].Split(' ');

            //    foreach (var item in noSpaces)
            //    {
            //        if (item != "")
            //        {
            //            result.Add(item);
            //        }

            //    }

            //}

            //Console.WriteLine(string.Join(" ", result));





            //Sum Adjacent Equal Numbers

            //List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();


            //int pos = 0;

            //while (pos < numbers.Count - 1)
            //{
            //    if (numbers[pos] == numbers[pos + 1])
            //    {   
            //        numbers.RemoveAt(pos);
            //        numbers[pos] = 2 * numbers[pos];
            //        pos--;
            //        if (pos < 0)
            //        {
            //            pos = 0;
            //        }


            //    }else
            //    {
            //        pos++;
            //    }



            //}


            //Console.WriteLine(string.Join(" ", numbers));






            //Split by Word Casing

            //char[] separators = new char[]
            //{',' , ';' , ':', '.', '!' , '(', ')', '\"', '\'', '/', '\\', '[', ']', ' '};

            //List<string> text = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            //List<string> lowerCase = new List<string>();
            //List<string> upperCase = new List<string>();
            //List<string> mixedCase = new List<string>();

            //foreach (var words in text)
            //{
            //    int lower = 0;
            //    int upper = 0;

            //    foreach (var letters in words)
            //    {
            //        if (char.IsLower(letters))
            //        {
            //            lower++;
            //        }else if(char.IsUpper(letters))
            //        {
            //            upper++;
            //        }

            //    }



            //    if (lower == words.Length)
            //    {
            //        lowerCase.Add(words);
            //    }else if(upper == words.Length)
            //    {
            //        upperCase.Add(words);
            //    }else
            //    {
            //        mixedCase.Add(words);
            //    }




            //}

            //Console.Write("lower-case: ");
            //Console.WriteLine(string.Join(", ", lowerCase));
            //Console.Write("mixed-case: ");
            //Console.WriteLine(string.Join(", ", mixedCase));
            //Console.Write("upper-case: ");
            //Console.WriteLine(string.Join(", ", upperCase));






            //Sort Numbers

            //List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            //numbers.Sort();
            //Console.WriteLine(string.Join(" <=", numbers));




            //Count numbers
            //List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //int[] counts = new int[numbers.Max() + 1];


            //foreach (var n in numbers)
            //{
            //    counts[n]++;

            //}

            //for (int i = 0; i < counts.Length; i++)
            //{
            //    if (counts[i] > 0)
            //    {
            //        Console.WriteLine($"{i} -> {counts[i]}");
            //    }
            //}





            //Matrix of Letters

            //int rows = int.Parse(Console.ReadLine());
            //int cols = int.Parse(Console.ReadLine());

            //char[,] matrix = new char[rows, cols];
            //char letter = 'A';

            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{

            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {

            //        matrix[row, col] = letter++;
            //        if (letter > 'Z')
            //        {
            //            letter = 'A';
            //        }
            //    }


            //}



            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{

            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        Console.Write((char)matrix[row, col] + " ");
            //    }

            //    Console.WriteLine();
            //}





            //Reading Matrices from the Console
            //int rows = int.Parse(Console.ReadLine());
            //int cols = int.Parse(Console.ReadLine());

            //int[,] matrix = new int[rows, cols];

            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    Console.Write($"row {row} -> ");
            //    int[] cells = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        matrix[row, col] = cells[col];

            //    }

            //}



            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{

            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        Console.Write(matrix[row, col] + " ");
            //    }
            //    Console.WriteLine();
            //}





            //Rotate a Matrix
            //int rows = int.Parse(Console.ReadLine());
            //int cols = int.Parse(Console.ReadLine());

            //string[,] matrix = new string[rows, cols];

            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    //Console.Write($"row {row} -> ");
            //    string[] sign = Console.ReadLine().Split(' ').ToArray();

            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        matrix[row, col] = sign[col];

            //    }

            //}


            //for (int col = 0; col < cols; col++)
            //{

            //    for (int row = rows - 1; row >= 0; row--)
            //    {
            //        Console.Write(matrix[row, col] + " ");
            //    }
            //    Console.WriteLine();
            //}






            /////////////////////////////////////////////////////////////////////////////////////////
            //Експерименти за Rotate a matrix
            //int rrows = cols;
            //int rcols = rows;
            //int[,] RotatedMatrix = new int[rrows, rcols];

            //for (int row = 0; row < rrows; row++)
            //{
            //    for (int col = 0; col < rcols; col++)
            //    {
            //        RotatedMatrix[row, col] = matrix[row, col];
            //    }
            //}




            //for (int row = 0; row < rrows; row++)
            //{
            //    for (int col = 0; col < rcols; col++)
            //    {
            //        Console.Write(RotatedMatrix[row, col] + " ");
            //    }
            //    Console.WriteLine();
            //}

            ///////////////////////////////////////////////////////////////////////////////////////

            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        Console.Write(matrix[row, col] + " ");
            //    }
            //    Console.WriteLine();

            //}

            ////////////////////////////////////////////////////////////////////////////////////////////




            //Sequence of Equal Elements

            //List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //List<int> result = new List<int>();

            //int counter = 0;
            //int temp = 0;


            //for (int i = 0; i < numbers.Count - 1; i++)
            //{

            //    if (numbers[i] == numbers[i + 1])
            //    {
            //        result.Add(numbers[i]);
            //    }

            //}



            //foreach (var item in result)
            //{
            //    Console.Write(item);
            //}


            ////////////////////////////////////////////////////////////////////////////////////////////
            int[] input = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

            List<int> temp = new List<int>();
            List<int> result = new List<int>();

            temp.Add(input[0]);   //Добавяме първия елемент от масива input в листа temp.
            for (int i = 1; i < input.Length; i++) //Започваме да обхождаме масива input
            {
                if (input[i] == input[i - 1])  //Сравнява текущия и миналия елемент 
                {
                    temp.Add(input[i]);         //Ако намери съвпадение добавя текущия елемент във                                  времения списък
                    if (i == input.Length - 1)  //Когато стигнем последния елемент от масива input                                правим същата проверка като в елзе - тоест проверяваме бройката елементи от времения списък temp дали е по-голяма от броят елементи в листа result, тоест ако в temp има повече резултати от листа result, последният се изчиства и след това му се добавят резултатите от листа temp.
                    {
                        if (temp.Count > result.Count)
                        {
                            result.Clear();
                            result.InsertRange(0, temp);
                        }
                    }
                }
                else                                     //Ако текущия и миналия елемент са различни
                {
                    if (temp.Count > result.Count)      //Проверяваме дали намерените резултати във                                     времения лист са повече от този на result. Ако                                    темп има повече намерени елементи, тоест поредица                                 от числа тогава изчистваме листа result и му                                      даваме намерената поредица числа от temp 
                    {
                        result.Clear();
                        result.InsertRange(0, temp);
                    }
                    temp.Clear();                   //След като сме предали поредицата от числа от temp                               на result , изчистваме temp и след това му предаваме                              текущия елемент. 
                    temp.Add(input[i]);
                }
            }


            Console.WriteLine("{0}", string.Join(" ", result));  






        }
    }
}
