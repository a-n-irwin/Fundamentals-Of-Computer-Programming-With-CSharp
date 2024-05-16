using System;
using System.Diagnostics.Metrics;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter07
    {
        public static class Ex04_MaximalSequenceOfConsecutiveEqualIntegers
        {
            // Contains main solution code 
            public static void Solution()
            {
                int[] array = { 1, 1, 2, 3, 2, 2, 2, 3, 3, 6, 1 };
                // int[] array = { 1, 1, 2, 3, 2, 2, 2, 1 };

                int index = 0;
                int count = 1;

                for (int i = 1, counter = 1; i < array.Length; ++i)
                {
                    counter = (array[i] != array[i - 1]) ? 1 : counter + 1;
                    int difference = array[i] * counter - array[index] * count;

                    // Checks if the sum of all consecutive occurrences of the current number is greater
                    // than the sum of all consecutive occurrences of the current maximal number
                    // This looks for the shortest sequence, hence "difference >= 0"
                    if (difference >= 0)
                    {
                        if (difference == 0 && counter >= count) continue;
                        // Or index = i; the below arithmetic is just so we arrive at the exact starting point.
                        index = i + 1 - counter;
                        count = counter;
                    }
                }

                Console.WriteLine("The array: ");
                foreach (int item in array) Console.Write($"{item} ");

                Console.WriteLine("\n\nThe maximal sequence of consecutive equal integers: ");
                for (int i = 0; i < count; ++i) Console.Write($"{array[index]} ");

                Console.WriteLine($"\nThe sum: {array[index] * count}");
            }
        }
    }
}