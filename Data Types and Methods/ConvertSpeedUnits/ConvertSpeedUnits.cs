using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine()); //in meters
       
            float miles = 1609f;

            float hours =   float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float time = (hours * 3600) + (minutes * 60) + seconds;
            float mps = distance / time;
            float kmh = (distance / 1000.0f) / (time / 3600.0f);
            float mph = (kmh / miles) * 1000.0f;

            //Console.WriteLine("{0:f6}", mps);
            //Console.WriteLine("{0:f6}", kmh);
            //Console.WriteLine("{0:f6}", mph);

            Console.WriteLine(mps);
            Console.WriteLine(kmh);
            Console.WriteLine(mph);


        }
    }
}
