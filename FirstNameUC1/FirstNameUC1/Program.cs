using System;

namespace FirstNameUC1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome To RegEx");
            ValidateFirstName fn = new ValidateFirstName();
            Console.WriteLine("Enter The FirstName :");
            String FirstName = Console.ReadLine();
            bool  result=fn.firstNameCheck(FirstName);
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
