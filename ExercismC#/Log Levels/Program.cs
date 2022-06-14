using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log_Levels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LogLine.Message("[ERROR]: Stack overflow"));            
            Console.WriteLine(LogLine.LogLevel("[ERROR]: Stack overflow"));            
            Console.WriteLine(LogLine.Reformat("[ERROR]: Stack overflow"));            
            Console.ReadLine();
        }
    }

    static class LogLine
    {
        public static string Message(string logLine)
        {
            string log = logLine.Substring(logLine.IndexOf(":") + 2);
            return log.Trim();
            throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
        }

        public static string LogLevel(string logLine)
        {
            int first = logLine.IndexOf("[");
            int last = logLine.IndexOf("]");
            return (logLine.Substring(first + 1, last - 1)).ToLower();

            throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
        }

        public static string Reformat(string logLine)
        {
            string message = Message(logLine);
            string level = LogLevel(logLine);
            return message + " (" + level + ")";
            throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
        }
    }

}
