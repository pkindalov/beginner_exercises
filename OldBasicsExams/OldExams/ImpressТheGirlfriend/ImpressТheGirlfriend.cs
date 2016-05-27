using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpressТheGirlfriend
{
    class ImpressТheGirlfriend
    {

        static double biggestNum(double a, double b, double c, double d, long e)
        {
            if (a > b && a > b && a > c && a > d && a > e)
            {
                return a;
            }
            else if (b > a && b > c && b > d && b > e)
            {
                return b;
            }
            else if(c > a && c > b && c > d && c > e)
            {
                return c;
            }
            else if (d > a && d > b && d > c && d > e)
            {
                return d;
            }
            else
            {
                return (double)e;
            }


        }




        static void Main(string[] args)
        {
            long rubles =        long.Parse(Console.ReadLine());
            long dollars =       long.Parse(Console.ReadLine());
            long euro =          long.Parse(Console.ReadLine());
            long specialOfferB = long.Parse(Console.ReadLine());  //leva
            long msite =         long.Parse(Console.ReadLine()); //leva


            double rublesConvertLv = (rubles / 100) * 3.5;
            double dollarsConvertLv = dollars * 1.5;
            double euroConvertLv = euro * 1.95;
            double b = specialOfferB / 2;


            Console.WriteLine("{0:f2}" , Math.Ceiling(biggestNum(rublesConvertLv, dollarsConvertLv, euroConvertLv, b, msite)));



        }
    }
}
