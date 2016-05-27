using System;

class SwimmingPoolVolume
{
    static void Main()
    {
        int v = int.Parse(Console.ReadLine());
        int p1 = int.Parse(Console.ReadLine());
        int p2 = int.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());



        int firstPipe = (int)h * p1;
        int secondPipe = (int)h * p2;
        int totalLiters = firstPipe + secondPipe;
        double totalLitersPourcent = 0;
        double firstPipeCommit = 0;
        double secondPipeCommit = 0;
        int resultFirstPipe = 0;
        int resultSecondPipe = 0;
        int totalLitersPourcentRes = 0;


        if (totalLiters < v)
        {
            
            totalLitersPourcent = ((double)totalLiters / v) * 100;
            totalLitersPourcentRes = (int)totalLitersPourcent;
            firstPipeCommit = ((double)firstPipe / totalLiters) * 100;
            resultFirstPipe = (int)firstPipeCommit;
            secondPipeCommit = ((double)secondPipe / totalLiters) * 100;
            resultSecondPipe = (int)secondPipeCommit;

            Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", totalLitersPourcentRes, resultFirstPipe, resultSecondPipe);
        }else if(totalLiters > v)
        {
            totalLitersPourcent = ((double)totalLiters / v) * 100;
            totalLitersPourcentRes = (int)totalLitersPourcent;
            double firstPipe2 = h * p1;
            double secondPipe2 = h * p2;
            int total = (int)(firstPipe2 + secondPipe2);

            Console.WriteLine("For {0} hours the pool overflows with {1} liters.", h, totalLitersPourcentRes);
            
        }

        
        

    }
}