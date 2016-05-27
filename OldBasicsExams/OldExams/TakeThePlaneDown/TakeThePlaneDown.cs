using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeThePlaneDown
{
    class TakeThePlaneDown
    {
        static void Main(string[] args)
        {

            int Xmybase = int.Parse(Console.ReadLine());
            int Ymybase = int.Parse(Console.ReadLine());
            int distanceToMyBorders = int.Parse(Console.ReadLine());
            int planesApproaching = int.Parse(Console.ReadLine());

            for (int i = 0; i < planesApproaching; i++)
            {
                int planeX = int.Parse(Console.ReadLine());
                int planeY = int.Parse(Console.ReadLine());

                int planeDistanceX = planeX - Xmybase;
                int planeDistanceY = planeY - Ymybase;

                double distanceToMyBase = Math.Sqrt((planeDistanceX * planeDistanceX) + (planeDistanceY * planeDistanceY));

                if (distanceToMyBorders >= distanceToMyBase)
                {
                    Console.WriteLine("You destroyed a plane at [{0},{1}]", planeX, planeY);
                }


            }



        }
    }
}
