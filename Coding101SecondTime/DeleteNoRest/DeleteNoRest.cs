using System;

class DeleteNoRest
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var p1 = 0.0;
        var p2 = 0.0;
        var p3 = 0.0;

        

        for (int i = 0; i < n; i++)
        {
            var numbers = int.Parse(Console.ReadLine());

            if ((numbers % 2) == 0)
            {
                p1++;
            }
            if ((numbers % 3) == 0)
            {
                p2++;
            }
            if ((numbers % 4) == 0)
            {
                p3++;
            }


        }

        var p1Purcent = p1 / n * 100;
        var p2Purcent = p2 / n * 100;
        var p3Purcent = p3 / n * 100;

        Console.WriteLine("{0:F2}%", p1Purcent);
        Console.WriteLine("{0:F2}%", p2Purcent);
        Console.WriteLine("{0:F2}%", p3Purcent);


    }
}