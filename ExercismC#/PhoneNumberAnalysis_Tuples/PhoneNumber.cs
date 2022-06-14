using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumberAnalysis_Tuples
{
    public static class PhoneNumber
    {
        public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
        { 
            string[] nums = phoneNumber.Split('-');
            //Console.WriteLine(string.Join(",",nums));
            return (nums[0] == "212", nums[1] == "555", nums[2]);
        }
        public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
        {
            return phoneNumberInfo.IsFake == true;
        }
    }


}
