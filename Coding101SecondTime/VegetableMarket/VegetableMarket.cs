using System;

class VegetableMarket
{
    static void Main()
    {
        double kgPriceVegetable = double.Parse(Console.ReadLine());
        double kgPriceFruits = double.Parse(Console.ReadLine());
        int totalKgVegetables = int.Parse(Console.ReadLine());
        int totalKgFruits = int.Parse(Console.ReadLine());

        double vegetableCoast = kgPriceVegetable * totalKgVegetables;  //3,7636 euro
        double fruitsCoasts = kgPriceFruits * totalKgFruits;           //376,36

        double total = vegetableCoast + fruitsCoasts;

        
        Console.WriteLine(total / 1.94);

    }
}