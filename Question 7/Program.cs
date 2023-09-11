using System;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            ReversedNumber();
        }
        public static void ReversedNumber()
        {
            Console.Write("Enter a number:");
            long number = long.Parse(Console.ReadLine());
            for ( ; ; )
            {
                long reminder = number % 10;
                long divide = number / 10;
                number = divide;
                Console.Write(reminder);
                if (divide == 0)
                {
                    break;
                }
            }
        }
    }
}
