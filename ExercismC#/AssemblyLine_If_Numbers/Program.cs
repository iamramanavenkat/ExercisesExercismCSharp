using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyLine_If_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //var converted = (Math.Round(ProductionRatePerHour(speed) / 60));
            //return converted;
            Console.WriteLine(AssemblyLine.SuccessRate(6));
            Console.WriteLine(AssemblyLine.ProductionRatePerHour(6));
            Console.WriteLine(AssemblyLine.WorkingItemsPerMinute(6));
            Console.ReadLine();
        }
    }
    static class AssemblyLine
    {
        public static double SuccessRate(int speed)
        {
            if (speed == 0) { return 0; }
            else if (speed >= 1 && speed <= 4) { return 1; }
            else if (speed >= 5 && speed <= 8) { return 0.9; }
            else if (speed == 9) { return 0.80; }
            else if (speed == 10) { return 0.77; }
            throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
        }
        public static double ProductionRatePerHour(int speed)
        {
            return speed * 221 * SuccessRate(speed); // 221 is number of cars produces per hour in speed 1(100% success rate).
            throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
        }
        public static int WorkingItemsPerMinute(int speed)
        {
            //int converted = (Math.Round(ProductionRatePerHour(speed) / 60));
            int converted = Convert.ToInt32((Math.Round(ProductionRatePerHour(speed) / 60))); // To convert minutes 60 were used.
            return converted;
            throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
        }
    }

}
