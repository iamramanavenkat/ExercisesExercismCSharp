using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public static class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(38.ToRoman());

            Console.ReadKey();
        }

        private static readonly Dictionary<int, string> dict = new Dictionary<int, string>
            {
                {1000,"M" },{900,"CM"}, {500,"D"}, {400,"CD"},{100,"C"},
                {90,"XC" }, {50,"L"}, {40,"XL"}, {10,"X"},{9,"IX"},{5,"V"},{4,"IV"},{1,"I"}

            };

        private static string ToRoman(this int value)
        {
            var romanLetter = new StringBuilder();

            foreach (var item in dict)
            {
                while (value / item.Key > 0)
                {
                    value = value - item.Key;
                    romanLetter.Append(item.Value);
                }
            }

            return romanLetter.ToString();
        }

    }
}
