using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2_BUS.Utility
{
    public class Utilities
    {
        public static bool IsEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9]+@(fpt.edu.vn)$");
        }

        public static bool IsPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^(0)[0-9]{9,10}");
        }

        public static bool Alphabectic(string str)
        {
            return Regex.IsMatch(str.Trim(), @"[a-zA-Z]+");
        }

        public static bool IsScores(string srt)
        {
            return Regex.IsMatch(srt, @"^[0-9]{1,2}(\.[0-9])?");
        }
    }
}
