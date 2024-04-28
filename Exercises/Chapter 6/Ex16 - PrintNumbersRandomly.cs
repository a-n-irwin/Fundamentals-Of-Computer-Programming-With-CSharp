using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter6
    {
        public static class Ex16_PrintNumbersRandomly
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter n: ");
                int n = int.Parse(Console.ReadLine());

                int[] numbers = new int[n];

                // Random number generator
                Random random = new Random();

                // Populate the array with numbers form 1 to n:
                for (int i = 0; i < numbers.Length; ++i) numbers[i] = i + 1;

                // Randomly select an index in the array and swap with the nth index, starting from 0, then swap with ith element
                for (int i = 0; i < numbers.Length; ++i)
                {
                    int index = random.Next(0, numbers.Length);

                    // Swap values of numbers[index] and numbers[i]
                    (numbers[index], numbers[i]) = (numbers[i], numbers[index]);
                }

                // Print the items of the array
                for (int i = 0; i < numbers.Length; ++i) Console.Write($"{numbers[i]} ");
            }
        }
    }
}