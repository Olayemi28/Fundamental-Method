using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method GetMax() with two integer (int) parameters, that 
            // returns maximal of the two numbers. Write a program that reads three 
            // numbers from the console and prints the biggest of them. Use the 
            // GetMax() method you just created. Write a test program that validates 
            // that the methods works correctly.

            Console.Write("Enter a number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter another number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter a number:");
            int num3 = int.Parse(Console.ReadLine());
            int maxNum = GetMax(GetMax(num1,num2), num3);
            Console.WriteLine($"The biggest of the number is {maxNum}");
        }
        static int GetMax(int num1, int num2)
        {
            int max=0;
            if(num1 > num2)
            {
                max = num1;
            }
            else if(num2 > num1)
            {
                max = num2;
            }
            return max;
        }
    }
}
