using System;

class Travelling
{
    static void Main()
    {
        double money = double.Parse(Console.ReadLine());
        string season = Console.ReadLine().ToLower();
        double seasonBudget = 0;

        if (money <= 100)
        {
            Console.WriteLine("Somewhere in Bulgaria");
            if (season == "summer")
            {
                seasonBudget = (money / 100) * 30;
                Console.WriteLine("Camp - {0:F2}", seasonBudget);
            }
            else
            {
                seasonBudget = (money / 100) * 70;
                Console.WriteLine("Hotel - {0:F2}", seasonBudget);
            }
            
        }else if(money <= 1000)
        {
            Console.WriteLine("Somewhere in Balkans");

            if (season == "summer")
            {
                seasonBudget = (money / 100) * 40;
                Console.WriteLine("Camp - {0:F2}", seasonBudget);
            }
            else
            {
                seasonBudget = (money / 100) * 80;
                Console.WriteLine("Hotel - {0:F2}", seasonBudget);
            }
        }else if(money > 1000)
        {

            Console.WriteLine("Somewhere in Europe"); 
            seasonBudget = (money / 100) * 90;
             Console.WriteLine("Hotel - {0:F2}", seasonBudget);
            

        }

    }
}