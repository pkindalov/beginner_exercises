using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{

    class Point
    {
        public double x { get; set; }
        public double y { get; set; }


    }



    class DistanceBetweenPoints
    {
        //static double point1(double x1,double x2)
        //{
        //    double result = Math.Abs(x1 - x2);
        //    return result;
        //}

        //static double point2(double y1, double y2)
        //{
        //    double result = Math.Abs(y1 - y2);
        //    return result;
        //}


        static Point ReadPoint()
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Point result = new Point();
            result.x = numbers[0];
            result.y = numbers[1];
            return result;
        }


        static double CalcDistance(Point p1, Point p2)
        {
            double deltaX = p2.x - p1.x;
            double deltaY = p2.y - p1.y;
            double result = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return result;
        }





        static void Main(string[] args)
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();
            double distance = CalcDistance(p1,p2);
            Console.WriteLine("Distance: {0:f3}", distance);


        }
    }
}
