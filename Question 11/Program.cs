using System;

namespace Question_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that solves the following tasks:
            // - Put the digits from an integer number into a reversed order.
            // - Calculate the average of given sequence of numbers.
            // - Solve the linear equation a * x + b = 0.
            // Create appropriate methods for each of the above tasks.
            // Make the program show a text menu to the user. By choosing an option 
            // of that menu, the user will be able to choose which task to be invoked.
            // Perform validation of the input data:
            // - The integer number must be a positive in the range [1…50,000,000].
            // - The sequence of numbers cannot be empty.
            // - The coefficient a must be non-zero.

           Menu();
        }
        static void Menu()
        {
            bool playOn = true;
            while (playOn)
            {
                Console.WriteLine("PRESS 1 TO CHECK FOR REVERSION OF NUMBER\nPRESS 2 TO CHECK FOR AVERAGE OF A SET OF A NUMBER\nPRESS 3 TO SOLVE FOR LINEAR EQUATION:");
                int reply;
                while (!(int.TryParse(Console.ReadLine(), out reply) && reply >= 1 && reply <= 3))
                {
                    Console.WriteLine("Number must either greater than or equals to 1 and must either less or equals to 3.");
                }
                if(reply == 1)
                {
                    Reverse();
                }
                else if(reply == 2)
                {
                    Average();
                }
                else if(reply == 3)
                {
                    LinearEquation();
                }
                Console.WriteLine();
                Console.Write("Press 4 to perform any other operation:");
                int response;
                while (!(int.TryParse(Console.ReadLine(), out response)))
                {
                    Console.Write("Invalid input");
                }
                if (response == 4)
                {
                    playOn = true;
                }
                else
                {
                    Console.Write("Thanks for using this app.");
                    playOn = false;
                }
            }
            Console.WriteLine();
        }
        static void Reverse()
        {
            Console.Write("Enter your preferred number:");
            int number;
            while (!(int.TryParse(Console.ReadLine(), out number) && number >= 1 && number <= 50000000))
            {
                Console.Write("Enter a number between 1 to 50000000:");
            }  
            for (; ; )
            {
                int divide = number / 10;
                int remain = number % 10; ;
                number = divide;
                Console.Write(remain);
                if (divide == 0)
                {
                    break;
                }
            }
            

        }
        static void Average()
        {
            Console.Write("Enter the length of the array:");
            int length;
            while (!(int.TryParse(Console.ReadLine(), out length) && length > 0))
            {
                Console.Write("Enter a length greater than zero(0): ");
            }
            int[] array = new int[length];
            double sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write($"Array[{i}]: ");
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
            }
            double average = sum / array.Length;
            Console.WriteLine("The result of an average of a number is {0:f3}", average);
        }
        static void LinearEquation()
        {
            Console.Write("Enter a number:");
            int a;
            while (!(int.TryParse(Console.ReadLine(), out a)))
            {
                Console.Write("The coefficient a must bea non-zero");
            }
            Console.Write("Enter another number:");
            int b = int.Parse(Console.ReadLine());
            int c = -b / a;
            Console.WriteLine($"The result of the linear equation of {b} and {a} is {c}");
        }
    }
}
