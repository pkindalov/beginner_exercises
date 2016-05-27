using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDessert
{
    class SweetDessert
    {
        static void Main(string[] args)
        {
            double ivanchoMoney = double.Parse(Console.ReadLine());
            int numberOfGuests = int.Parse(Console.ReadLine());
            double bananasPrice = double.Parse(Console.ReadLine());
            double eggsPrice = double.Parse(Console.ReadLine());
            double priceOfBerries = double.Parse(Console.ReadLine());

            int portions = 6;
            int set = numberOfGuests / portions;

            if (set * portions < numberOfGuests)
            {
                set++;
            }


            double priceOfneededProducts =  set * (2 * bananasPrice) + set * (4 * eggsPrice) + set * (0.2 * priceOfBerries);


            if (priceOfneededProducts < ivanchoMoney)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", priceOfneededProducts);
            }
            else
            {
                double neededMoney = priceOfneededProducts - ivanchoMoney;
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", neededMoney);
            }


            //Console.WriteLine(priceOfneededProducts);
            //Console.WriteLine(set);
            //Console.WriteLine(portions);

        }
    }
}
