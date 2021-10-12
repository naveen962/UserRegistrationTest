using System;

namespace ValidatePhoneNoUC4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To RegEx");


            Console.WriteLine("Enter The Phone  Number :");
            string phno =Console.ReadLine();
            ValidatePhno ph = new ValidatePhno();
            bool result = ph.PhoneCheck(phno);
            if (result == true)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }


        }
    }
}
