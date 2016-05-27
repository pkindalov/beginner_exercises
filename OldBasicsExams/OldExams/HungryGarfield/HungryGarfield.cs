using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryGarfield
{
    class HungryGarfield
    {
        static void Main(string[] args)
        {
            //Budget
            decimal moneyDollars =   decimal.Parse(Console.ReadLine());
            decimal dollarExchange = decimal.Parse(Console.ReadLine());

            //Food prices -!!!!! LEVA !!!!!!!
            decimal pizzaPriceLeva =    decimal.Parse(Console.ReadLine());
            decimal lazzagnePriceLeva = decimal.Parse(Console.ReadLine());
            decimal sandwichPriceLeva = decimal.Parse(Console.ReadLine());

            //Food Quantity
            long pizzaQuantity =    long.Parse(Console.ReadLine());
            long lazzagneQuantity = long.Parse(Console.ReadLine());
            long sandwichQuantity = long.Parse(Console.ReadLine());

            decimal sum = (pizzaPriceLeva / dollarExchange) * pizzaQuantity + (lazzagnePriceLeva / dollarExchange) * lazzagneQuantity + (sandwichPriceLeva / dollarExchange) * sandwichQuantity;
            decimal totalSum = Math.Round(sum, 2);

            decimal moneyLeft = 0m;
            decimal moneyNeed = 0m;

            if (moneyDollars > totalSum)
            {
                moneyLeft = moneyDollars - totalSum;
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", moneyLeft);
            }
            else
            {
                moneyNeed = totalSum - moneyDollars;
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.", moneyNeed);
            }

           

        }
    }
}
