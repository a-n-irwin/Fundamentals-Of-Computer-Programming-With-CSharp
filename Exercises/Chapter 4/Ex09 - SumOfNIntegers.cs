using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter4
    {
        public static class Ex09_SumOfNIntegers
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter n: ");
                int n = int.Parse(Console.ReadLine());

                int sum = 0;

                for (int i = 0; i < n; ++i)
                {
                    // It's good to let the user know how much input they will be requested to make
                    Console.Write($"Enter any integer ({i + 1} of {n}): ");
                    sum += int.Parse(Console.ReadLine());
                }

                Console.WriteLine($"The sum of these numbers is {sum}");
            }
        }
    }
}