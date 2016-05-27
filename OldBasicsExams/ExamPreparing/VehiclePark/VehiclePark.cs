using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclePark
{
    class VehiclePark
    {
        static void Main(string[] args)
        {
            List<string> venicles = Console.ReadLine().Split(' ').ToList();

            string command = Console.ReadLine();
            int foundCount = 0;
            int sold = 0;
            while (command != "End of customers!")
            {
                string[] commandArray = command.ToLower().Split(' ').ToArray();
                string searching = commandArray[0][0] + commandArray[2];
                

               
                    if (venicles.Contains(searching))
                    {
                        int value = (int)commandArray[0][0] * int.Parse(commandArray[2]);
                        foundCount++;
                        sold = venicles.Count - 1;
                        Console.WriteLine("Yes, sold for {0}$", value);
                        venicles.Remove(searching);    
                        
                        //Console.WriteLine("Yes, sold for {0}", value);
                       
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }



                // Console.WriteLine("Vehicles sold: {0}" , sold);

                
                command = Console.ReadLine();
            }

            Console.Write("Vehicles left: ");
            Console.Write(string.Join(", ", venicles));
            Console.WriteLine();
            Console.WriteLine("Vehicles sold: {0}", foundCount);
        }
    }
}
