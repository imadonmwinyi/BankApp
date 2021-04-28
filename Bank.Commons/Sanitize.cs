using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace Bank.Lib.Commons
{
    public class Sanitize
    {
        public static string RemoveDigit(string str)
        {
            string output = Regex.Replace(str, @"[\d]", string.Empty);
            return output;
        }
        public static string Capitalize(string str)
        {
            if (string.IsNullOrEmpty(str))
                throw new Exception("Empty Input");
            if (char.IsUpper(str[0]) && str.Length > 1)
                return str;
            var s = char.ToUpper(str[0]) + str.Substring(1);
            return s;
        }
    }
}
