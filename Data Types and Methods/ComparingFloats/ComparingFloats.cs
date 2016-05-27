using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double numA = double.Parse(Console.ReadLine());
            double numB = double.Parse(Console.ReadLine());
            double eps = 0.000001d;

            bool isEqual = (Math.Abs(numA - numB)) < eps;

            Console.WriteLine(isEqual);


            //second way 
            //decimal numA = decimal.Parse(Console.ReadLine());
            //decimal numB = decimal.Parse(Console.ReadLine());

            //bool isEqual = (numA == numB);

            //Console.WriteLine(isEqual);
        }
    }
}
