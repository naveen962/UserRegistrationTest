using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidatePhoneNoUC4
{
   public class ValidatePhno
   {
        
        
            
            public string Pattern = "^[9]{1}[1]{1}[0-9]{10}$";
            public bool PhoneCheck(string phone)
            {
                return Regex.IsMatch(phone, Pattern);
            }

        
    }
}
