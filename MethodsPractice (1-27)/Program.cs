using System;

namespace MethodsPractice__1_27_
{
    class Program
    {
        static void Main(string[] args)
        {
            string presidentName = GetPresidentName();
            string companyName = GetCompanyName();
            WelcomeMessage(presidentName); // method call
            WelcomeMessage(companyName);

            Console.ReadKey();
        }

        static string GetCompanyName()
        {
            Console.Write("Please enter the name of the company: ");
            string name = Console.ReadLine();
            return name;
        }


        static string GetPresidentName()
        {
            Console.Write("Please enter the name of the president: ");
            string name = Console.ReadLine();
            return name;
        }

        // make sure you define methods inside the class
        static void WelcomeMessage(string name) // method definition
        {
            Console.WriteLine("Welcome to AIMS! My name is " + name);
        }
    }
}
