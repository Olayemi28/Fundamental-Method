using System;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that returns the position of the first occurrence of an 
            // element from an array, such that it is greater than its two neighbors 
            // simultaneously. Otherwise the result must be -1.

            Console.Write("Enter the length of the array:");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"array[{i}]: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter the element in the array:");
            int element = int.Parse(Console.ReadLine());

            int result = GreaterThanNeighbour(array, element);
            Console.WriteLine(result);
        }
        static int GreaterThanNeighbour(int[] array, int num)
        {
            int elementPosition = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    elementPosition = i;
                    break;
                }
            }
            if (elementPosition == 0 && array.Length == 1)
            {
                return elementPosition;
            }
            else if (elementPosition == 0 && (array.Length - 1) > 1)
            {
                if (array[elementPosition] > array[elementPosition + 1])
                {
                    return elementPosition;   
                }
                else
                {
                    elementPosition = -1;
                    return elementPosition;
                }
            }
            else if(elementPosition == array[array.Length - 1])
            {
                if (array[elementPosition] > array[elementPosition - 1])
                {
                    return elementPosition;
                }
                else
                {
                    elementPosition = -1;
                    return elementPosition;
                }
            }
            else if(elementPosition != 0 && elementPosition != array[array.Length - 1])
            {
                if (array[elementPosition] > array[elementPosition - 1] && array[elementPosition] > array[elementPosition + 1])
                {
                    return elementPosition;
                }
                else
                {
                    elementPosition = -1;
                    return elementPosition;
                }
            }
            else
            {
                elementPosition = -1; 
                return elementPosition;
            }
        }
    }
}
