using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter6
    {
        // Similar with chapter 4 exercise 10
        public static class Ex01_PrintNumbers
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter n: ");
                int n = int.Parse(Console.ReadLine());

                for (int integer = 1; integer <= n; ++integer)
                {
                    Console.Write($" {integer}");
                }
            }
        }
    }
}