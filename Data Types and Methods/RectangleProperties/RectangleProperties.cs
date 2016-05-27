using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProperties
{
    class RectangleProperties
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = width * height;
            double perimeter = 2 * (width + height);

            
            Console.WriteLine(perimeter);
            Console.WriteLine(area);

            width *= width;
            height *= height;
            
            double result = (Math.Sqrt(width + height));
            Console.WriteLine(result);
        }
    }
}
