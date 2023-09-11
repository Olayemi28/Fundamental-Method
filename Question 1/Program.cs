using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a code that by given name prints on the console "Hello, <name>!"
            // (for example: "Hello, Peter!").
            Console.Write("Enter your first name:");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name:");
            string lastName = Console.ReadLine();
            string fullName = (firstName + lastName);
            
            Console.WriteLine(SayHi(fullName));
        }
        static string SayHi(string name)
        {
            return $"Hello,{name}";
        } 
    }
}
