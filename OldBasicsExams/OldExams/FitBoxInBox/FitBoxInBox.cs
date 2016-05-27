using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBoxInBox
{
    class FitBoxInBox
    {
        static void findSmallerBox(int b1Width, int b1Height, int b1Deph, int b2Width, int b2Height, int b2Deph)
        {
            if (b1Width < b2Width && b1Height < b2Height && b1Deph < b2Deph )
            {
                
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", b1Width, b1Height, b1Deph, b2Width, b2Height, b2Deph);
                
            }
            
        }







        static void Main(string[] args)
        {
            #region box1
            int box1Width = int.Parse(Console.ReadLine());
            int box1Height = int.Parse(Console.ReadLine());
            int box1Deph = int.Parse(Console.ReadLine());
            #endregion

            #region box2
            int box2Width = int.Parse(Console.ReadLine());
            int box2Height = int.Parse(Console.ReadLine());
            int box2Deph = int.Parse(Console.ReadLine());
            #endregion


            #region findAndWriteSmallerBox
            findSmallerBox(box1Width, box1Height, box1Deph, box2Width, box2Height, box2Deph);
            findSmallerBox(box1Width, box1Height, box1Deph, box2Width, box2Deph, box2Height);
            findSmallerBox(box1Width, box1Height, box1Deph, box2Height, box2Width, box2Deph);
            findSmallerBox(box1Width, box1Height, box1Deph, box2Height, box2Deph, box2Width);
            findSmallerBox(box1Width, box1Height, box1Deph, box2Deph, box2Width, box2Height);
            findSmallerBox(box1Width, box1Height, box1Deph, box2Deph, box2Height, box2Width);
            #endregion


            findSmallerBox(box2Width, box2Height, box2Deph, box1Width, box1Height, box1Deph);
            findSmallerBox(box2Width, box2Height, box2Deph, box1Width, box1Deph, box1Height);
            findSmallerBox(box2Width, box2Height, box2Deph, box1Height, box1Width, box1Deph);
            findSmallerBox(box2Width, box2Height, box2Deph, box1Height, box1Deph, box1Width);
            findSmallerBox(box2Width, box2Height, box2Deph, box1Deph, box1Width, box1Height);
            findSmallerBox(box2Width, box2Height, box2Deph, box1Deph, box1Height, box1Width);



        }
    }
}
