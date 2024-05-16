using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter07
    {
        public static class Ex07_MaximalSequenceOfConsecutiveIntegers
        {
            // Contains main solution code 
            public static void Solution()
            {
                bool condition = true;

                int k = 0;
                int n = 0;

                // Persistent input prompt with partial input validation
                while (condition)
                {
                    Console.Write("Enter k: ");
                    k = int.Parse(Console.ReadLine());

                    Console.Write("Enter n: ");
                    n = int.Parse(Console.ReadLine());

                    condition = k >= n;

                    if (condition)
                    {
                        Console.WriteLine("\nK must be less than N (i.e K < N). Please re-enter the inputs below.\n");
                    }
                }

                int[] array = new int[n];

                // Get inputs for the array
                Console.WriteLine();
                for (int i = 0; i < array.Length; ++i)
                {
                    Console.Write($"Enter item {i + 1} of {array.Length}: ");
                    array[i] = int.Parse(Console.ReadLine());
                }

                int index = 0;
                int sum = int.MinValue;

                // Find the K consecutive elements in the array with the maximal sum
                for (int i = 0, aggregate = 0; i < n; ++i)
                {
                    aggregate += (i < k) ? array[i] : -array[i - k] + array[i];
                    if (aggregate > sum)
                    {
                        sum = aggregate;
                        index = i + 1 - k;
                    }
                }

                // Print the elements and the sum
                Console.WriteLine($"\nThe {k} consecutive elements with the maximal sum: ");

                for (int i = index; i < index + k; ++i)
                {
                    Console.Write($"{array[i]} ");
                }

                Console.WriteLine($"\nThe sum is {sum}");
            }
        }
    }
}