using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LastNameUC2
{
   public class ValidateLastname
    {
        public string pattern = "^[A-Z]{1}[a-z]{3}";
        public bool ValidateLastnameCheck(string name)
        {
            return Regex.IsMatch(name, pattern);
        }
        
       
    }
}
