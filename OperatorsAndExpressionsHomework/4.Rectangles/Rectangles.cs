using System;

    class Rectangles
    {
        static void Main()
        {
            //Write an expression that calculates rectangle’s perimeter and area by given width and height.

            Console.WriteLine("Enter width of rectangle: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Height of rectangle: ");
            double height = double.Parse(Console.ReadLine());

            double perimeterRectangle = (width + height) * 2;
            double areaRectangle = width * height;

            Console.WriteLine("Perimeter of rectangle: {0} Area: {1}", perimeterRectangle, areaRectangle);

        }
    }
