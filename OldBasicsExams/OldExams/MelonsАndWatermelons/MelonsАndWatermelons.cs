using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelonsАndWatermelons
{
    class MelonsАndWatermelons
    {
        static void Main(string[] args)
        {
            int startingDay = int.Parse(Console.ReadLine());
            int seq = int.Parse(Console.ReadLine());

            int watermelon = 0;
            int melon = 0;

            for (int i = startingDay; i < (startingDay + seq); i++)
            {
                switch (i % 7)
                {
                    case 1:
                        watermelon++;
                        break;
                    case 2:
                        melon += 2;
                        break;
                    case 3:
                        watermelon++;
                        melon++;
                        break;
                    case 4:
                        watermelon += 2;
                        break;
                    case 5:
                        watermelon += 2;
                        melon += 2;
                        break;
                    case 6:
                        watermelon++;
                        melon += 2;
                        break;
                    
                    default:
                        break;
                }
            }


            //Console.WriteLine("Watermelons: {0}", watermelon);
            //Console.WriteLine("Melon: {0}", melon);

            if (watermelon > melon)
            {
                int total = watermelon - melon;
                Console.WriteLine("{0} more watermelons", total);
            }
            else if(melon > watermelon)
            {
                int total = melon - watermelon;
                Console.WriteLine("{0} more melons", total);
            }
            else
            {
                Console.WriteLine("Equal amount: {0}", watermelon);
            }



        }
    }
}
