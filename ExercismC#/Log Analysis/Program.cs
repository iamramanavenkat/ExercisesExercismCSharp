using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log_Analysis
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public static class LogAnalysis
    {
        // TODO: define the 'SubstringAfter()' extension method on the `string` type
        public static string SubstringAfter(this string str, string delimiter)
        {

            //return str.Substring(str.IndexOf(delimiter)+delimiter.Length);

            string[] a = str.Split(delimiter);
            return a[1];
        }
        // TODO: define the 'SubstringBetween()' extension method on the `string` type
        public static string SubstringBetween(this string str, string d1, string d2)
        {
            var a = str.IndexOf(d1) + d1.Length;
            var b = str.IndexOf(d2);
            return str.Substring(a, b - a);
        }


        // TODO: define the 'Message()' extension method on the `string` type

        public static string Message(this string str)
        {
            string[] a = str.Split(": ");
            return a[1];
        }
        // TODO: define the 'LogLevel()' extension method on the `string` type

        public static string LogLevel(this string str)
        {
            return str.Substring(str.IndexOf("[") + 1, str.IndexOf("]") - 1);
        }
    }
}
