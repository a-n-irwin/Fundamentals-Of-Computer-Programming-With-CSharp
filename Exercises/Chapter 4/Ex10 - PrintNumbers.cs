using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter4
    {
        public static class Ex10_PrintNumbers
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter n: ");
                int n = int.Parse(Console.ReadLine());

                for (int integer = 1; integer <= n; ++integer)
                {
                    Console.WriteLine(integer);
                }
            }
        }
    }
}