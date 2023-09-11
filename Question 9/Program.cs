using System;

namespace Question_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that finds the biggest element of an array. Use that 
            // method to implement sorting in descending order.
            Console.Write("Enter the length of the array:");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length]; 
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"array[{i}]: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            BiggestElement(array);
        }
        static void BiggestElement(int[] array)
        {
            int biggestElement = 0, saveCurrentElement = 0;
            for (int i = 0; i < array.Length; i++)
            {
                biggestElement = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] > array[biggestElement])
                    {
                        biggestElement = j;
                    }
                }
                saveCurrentElement = array[biggestElement];
                array[biggestElement] = array[i];
                array[i] = saveCurrentElement;
                Console.Write($"{saveCurrentElement}, ");
            }
        }
    }
}
