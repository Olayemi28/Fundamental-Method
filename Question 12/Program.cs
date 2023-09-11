using System;
using System.Collections.Generic;

namespace Question_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
        }
        static void Add()
        {
            int[] a = new int[3];
            int[] b = new int[3];
            int[,] c = new int[3, 3];
            int[] d = new int[5];
            for (int i = 0, j = 2; i < 6; i++)
            {
                Console.WriteLine($"Enter a number x^{j} for eqn 1:");
                a[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter a number x^{j} for eqn 2:");
                b[i] = int.Parse(Console.ReadLine());
                c[i, j] = a[i] + b[j];
                j--;
            }
            Console.WriteLine($"");
        }
    }
}
