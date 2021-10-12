using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FirstNameUC1
{
    public class ValidateFirstName
    {
        
        public string Pattern = "^[A-Z]{1}[a-z]{3}";
        public bool firstNameCheck(string name)
        {
            return Regex.IsMatch(name, Pattern);
        }

    }
}
