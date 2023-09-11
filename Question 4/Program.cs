using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that finds how many times certain number can be 
            // found in a given array. Write a program to test that the method works 
            // correctly.

            Console.Write("Enter the length of the array:");
            int length = int.Parse(Console.ReadLine());
            int[] num = new int[length];
            for(int i = 0; i < num.Length; i++)
            {
                Console.Write($"Number[{i}] = ");
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter the certain number to find its occurence:");
            int number = int.Parse(Console.ReadLine());
            CountOccurence(num, number);
        }

        static void CountOccurence(int[] array, int num)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == num)
                {
                    count++;
                }
            }
            Console.WriteLine($"Element {num} occurs {count} time(s).");
        }


















        // static void MostOccurrenceNumber(int[] array)
        // {
        //     int currentCount = 0, mostOccuredElement = 0, maxCount = 0, currentElement = 0;
        //     for (int i = 0; i <= array.Length - 1; i++)
        //     {
        //         for (int j = i; j <= array.Length - 1; j++)
        //         {
        //             if(array[i] == array[j])
        //             {
        //                 currentCount++;
        //                 if(currentCount > maxCount)
        //                 {
        //                     currentElement = array[i];
        //                     mostOccuredElement = array[i];
        //                     maxCount = currentCount;
        //                 }
        //             }
        //         }
        //         currentCount = 0;
        //     }
        //     Console.Write($"Element {mostOccuredElement} occurs {maxCount} times");
        // }
    }
}
