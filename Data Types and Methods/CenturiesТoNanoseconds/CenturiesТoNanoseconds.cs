using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesТoNanoseconds
{
    class CenturiesТoNanoseconds
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());

            uint years = (uint)centuries * 100;
            ulong days = (ulong)(years * 365.2422);
            ulong hours = days * 24;
            ulong minutes = hours * 60;
            ulong seconds = minutes * 60;
            ulong milisecond = seconds * 1000;
            ulong microsecond = milisecond * 1000;
            decimal nanoseconds = (decimal)microsecond * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milisecond} milliseconds = {microsecond} microseconds = {nanoseconds} nanoseconds");


         }
    }
}
