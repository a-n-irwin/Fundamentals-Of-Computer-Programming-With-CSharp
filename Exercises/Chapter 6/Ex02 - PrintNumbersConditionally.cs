using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter6
    {
        // Similar with chapter 4 exercise 10
        public static class Ex02_PrintNumbersConditionally
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter n: ");
                int n = int.Parse(Console.ReadLine());

                // The smallest number that 3 and 7 have in common (The least common multiple)
                int lcm3n7 = 21;

                for (int integer = 1; integer <= n; ++integer)
                {
                    // Basically, every 21st number will be skipped
                    if (integer % lcm3n7 != 0) Console.Write($" {integer}");
                }
            }
        }
    }
}