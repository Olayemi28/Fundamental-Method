using System;
using System.Numerics;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine($"The factorial of {number} is {CalculateFactorialNumber(number)}"); 
        }
        static BigInteger CalculateFactorialNumber(BigInteger num)
        {
            BigInteger factorial = 1;
            if (num > 0 && num <= 100)
            {
                for (int a = 1; a <= num; a++)
                {
                    factorial *= a;
                }
            }
            else
            {
                Console.WriteLine("Input is out of range");
            }
            return factorial;
        } 
    }
}
