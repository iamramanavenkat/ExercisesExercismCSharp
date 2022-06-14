using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuciansLusciousLasagna
{
    class Program
    {
        static void Main(string[] args)
        {
            var lasgana = new Lasgana();
            // lasgana.ExpectedMinutesInOven();
            //lasgana.RemainingMinutesInOven(20);
            //lasgana.PreparationTimeInMinutes(3);
            //lasgana.ElapsedTimeInMinutes(3, 20);
            Console.WriteLine(lasgana.ExpectedMinutesInOven());
            Console.WriteLine(lasgana.RemainingMinutesInOven(20));
            Console.WriteLine(lasgana.PreparationTimeInMinutes(3));
            Console.WriteLine(lasgana.ElapsedTimeInMinutes(3, 20));
            Console.ReadLine();
        }

        class Lasgana
        {
            int minutes = 40;
            public int ExpectedMinutesInOven()
            {
                return minutes;
            }
            public int RemainingMinutesInOven(int waitmins)
            {
                return minutes - waitmins;
            }
            public int PreparationTimeInMinutes(int no_of_layers)
            {
                return no_of_layers * 2;
            }
            public int ElapsedTimeInMinutes(int no_of_layers, int no_of_mins)
            {
                return (no_of_mins * 2) + no_of_layers;
            }


        }

    }

}
