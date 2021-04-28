using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Lib.Commons
{
    public class Seperators
    {
        /// <summary>
        /// Separate string by dash
        /// </summary>
        /// <param name="str"></param>
        /// <returns>array of the two string</returns>
        public static string[] TwoStringByDash(string str)
        {
            string[] sub = new string[2];
            sub[0] = str.Substring(0, str.IndexOf('-'));
            sub[1] = str.Substring(str.IndexOf('-') + 1);
            return sub;
        }
    }
}
