using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter4
    {
        public static class Ex06_MaximumOfTwoNumbers
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter two integers: ");
                string[] input = Console.ReadLine().Split();

                double a = double.Parse(input[0]);
                double b = double.Parse(input[1]);

                double max = Math.Max(a, b);
                Console.WriteLine("Max: {0}", max);
            }
        }
    }
}