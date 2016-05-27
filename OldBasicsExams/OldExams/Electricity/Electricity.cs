using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity
{
    class Electricity
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int flats = int.Parse(Console.ReadLine());

            DateTime date = DateTime.Parse(Console.ReadLine());
            string time = date.ToString("HH:mm");

            


            decimal lamps = 0;
            decimal computers = 0;
            decimal result = 0;

            if (string.Compare(time, "14:00") >= 0 && string.Compare(time, "19:00") < 0)
            {
                lamps = 2;
                computers = 2;
                result = (floors * flats) * ((lamps * 100.53m) + (computers * 125.90m));
                Console.WriteLine("{0} Watts", (int)result);

            }
            else if (string.Compare(time, "19:00") >= 0 && string.Compare(time, "24:00") < 0)
            {
                lamps = 7;
                computers = 6;
                result = (floors * flats) * ((lamps * 100.53m) + (computers * 125.90m));
                Console.WriteLine("{0} Watts", (int)result);
            }
            else if (string.Compare(time, "00:00") >= 0 && string.Compare(time, "09:00") < 0)
            {
                lamps = 1;
                computers = 8;
                result = (floors * flats) * ((lamps * 100.53m) + (computers * 125.90m));
                Console.WriteLine("{0} Watts", (int)result);
            }
            else
            {
                Console.WriteLine("0 Watts");
            }
        }
    }
}
