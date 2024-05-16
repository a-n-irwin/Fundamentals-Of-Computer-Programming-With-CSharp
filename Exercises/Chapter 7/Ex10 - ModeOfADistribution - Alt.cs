using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter07
    {
        public static class Ex10_ModeOfADistrubution_Alt
        {
            // Contains main solution code 
            public static void Solution()
            {
                int?[] data = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

                // Print the array first, because it will be modified
                Console.WriteLine($"The array: ");
                foreach (int? item in data) Console.Write($"{item} ");

                Array.Sort(data);

                int index = 0;
                int count = 1;

                // Check for the longest sequence of consecutive equal integers
                // This code is adapted from exercise 4
                for (int i = 1, counter = 1; i < data.Length; ++i)
                {
                    counter = (data[i] != data[i - 1]) ? 1 : counter + 1;
                    // Checks if the sum of all consecutive occurrences of the current number is greater
                    // than the sum of all consecutive occurrences of the current maximal number
                    // This looks for the shortest sequence, hence "difference >= 0"
                    if (counter > count)
                    {
                        // Or index = i; the below arithmetic is just so we arrive at the exact starting point.
                        index = i + 1 - counter;
                        count = counter;
                    }
                }

                // Print the result
                Console.WriteLine($"\n\nThe most occuring element is {data[index]}({count} times)");
            }
        }
    }
}