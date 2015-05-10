using System;



    class PointInsideACircleOutsideOfARectangle
    {
        static void Main()
        {
            //Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

            Console.WriteLine("Enter X: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y: ");
            double y = double.Parse(Console.ReadLine());
            double radius = 1.5;
            double xCenter = 1;
            double yCenter = 1;

            bool isOutOfRect = false;
            bool isInCircle = ((x - xCenter) * (x - xCenter) + (y - yCenter) * (y - yCenter) <= (radius * radius));

            if(isInCircle)
            {
                isOutOfRect = (x > 5 )|| (x < -1) || (y > 1) || (y < -1);
                Console.WriteLine(isOutOfRect + "\n");
               
            }
            else
            {
                Console.WriteLine(isOutOfRect + "\n");
            }
            




        }
    }

