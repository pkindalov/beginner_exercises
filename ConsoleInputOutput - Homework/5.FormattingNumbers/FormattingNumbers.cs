using System;
using System.Threading;
using System.Globalization;


    class FormattingNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());

            //if(a < 0 || a > 500)
            //{
            //    Console.WriteLine("Invalid number. Please try again.");
            //    return;
            //}

            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            float c = float.Parse(Console.ReadLine());

            //string hexA = a.ToString("X");          //Convert integer number to hexademical
            ////Console.Write(hexA);
            //string hexb = b.ToString("X");
            //string hexC = c.ToString("X");


            Console.WriteLine("{0,-10:X} | {1,10:0.0000000000} | {2,4:F2}| {3,-10:F3} |", a, Convert.ToString(a,2).PadLeft(10,'0'), b,c);




        }
    }

