using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace Bank.Lib.Commons
{
    public static class Validation
    {
        /// <summary>
        /// Check if the email is in a proper format
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool EmailValidation(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!regex.Match(email).Success)
                throw new Exception("Email Format Is not Correct");
            return true;
        }
        public static void ValueNotEmpty(string val)
        {
            if (String.IsNullOrEmpty(val))
                throw new Exception(" Input cannot be Empty");
            
        }
    }
}
