using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that returns the English name of the last digit of a 
            // given number. Example: for 512 prints "two"; for 1024  "four".

            Console.Write("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            Words(num);
        }
        static int Words(int num)
        {
            int a = num % 10;
            switch (a)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
            return num;
        }
    }
}
