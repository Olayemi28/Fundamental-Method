using System;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that checks whether an element, from a certain position 
            // in an array is greater than its two neighbors. Test whether the 
            // method works correctly.
            Console.Write("Enter the length of the array:");
            int length = int.Parse(Console.ReadLine());
            
            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
               Console.Write($"array[{i}]: ");
               array[i] = int.Parse(Console.ReadLine()); 
            }
            Console.Write("Enter the position of the array:");
            int position = int.Parse(Console.ReadLine());
            bool result = GreaterThanNeighbours(array, position);
            Console.WriteLine(result);
        }
        static bool GreaterThanNeighbours(int[] number, int position)
        {
            bool greatestElement = true;
            int greatest = 0;

            if (position == 0 && number.Length == 1)
            {
                greatestElement = true;
            }
           else if (position == 0 && (number.Length - 1) > 1)
           {
                greatest = (number[position] - number[position + 1]);
                if(greatest > 0)
                {
                    greatestElement = true;
                }
                else
                {
                    greatestElement = false;
                    return greatestElement;
                }
           }
           else if (position == number.Length - 1)
           {
                greatest = (number[position] - number[position - 1]);
                if (greatest > 0)
                {
                    greatestElement = true;
                }
                else
                {
                    greatestElement = false;
                    return greatestElement;
                }
           }
           else if(position != 0 && position != number.Length - 1)
           {
                if(number[position] > number[position - 1] && number[position] > number[position + 1])
                {
                    greatestElement = true;
                }
                else
                {
                    greatestElement = false;
                    return greatestElement;
                }
           }
           else
           {
             greatestElement = false;
             return greatestElement;
           }
            return greatestElement;
        }
    }
}
