using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumberAnalysis_Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var result1 = PhoneNumber.Analyze("212-502-1234");
            var result2 = (PhoneNumber.IsFake(PhoneNumber.Analyze("212-555-1234")));
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.ReadLine();
        }
    }
}
