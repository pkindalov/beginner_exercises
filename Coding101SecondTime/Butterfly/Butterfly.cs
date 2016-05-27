using System;

class Butterfly
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());


        if (n <= 3)
        {
            Console.Write("*\\ ");
            Console.Write("/*");
            Console.WriteLine();

            Console.Write(new string(' ', 4 /2));
            Console.Write("@");
            Console.Write(new string(' ', 4 / 2));
            Console.WriteLine();

            Console.Write("*/ ");
            Console.Write("\\*");
            Console.WriteLine();
        }



        //top
        int StarsCount = n - 2;

        string stars = new string('*', n - 2);
        string leftLine = new string('\\', n - StarsCount - 1);
        string spaces = new string(' ', n - StarsCount - 1);
        string rightLine = new string('/', n - StarsCount - 1);
        string dots = new string('-', n - 2);

        Console.Write(stars);
        Console.Write(leftLine);
        Console.Write(spaces);
        Console.Write(rightLine);
        Console.Write(stars);
        Console.WriteLine();


        for (int i = 1; i < 2 * (n - 2); i++)
        {
            //Console.WriteLine(i);
            if(i == 1 || i == (2 * (n - 2)) - 1)
            {
                Console.Write(dots);
                Console.Write(leftLine);
                Console.Write(spaces);
                Console.Write(rightLine);
                Console.Write(dots);
                Console.WriteLine();
            }

            if(i >= (2 * (n - 2)))
            {

            }


        }






        //bottom
        string bottomLeftLine = new string('/', n - StarsCount - 1);
        string bottomRightLine = new string('\\', n - StarsCount - 1);
        Console.Write(stars);
        Console.Write(bottomLeftLine);
        Console.Write(spaces);
        Console.Write(bottomRightLine);
        Console.Write(stars);
    }
}