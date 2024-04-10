using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter4
    {
        public static class Ex08_MaximumOfFiveNumbers
        {
            // Contains main solution code 
            public static void Solution()
            {
                int counter = 0;
                double max = 0;

                while (counter < 5)
                {
                    Console.Write($"Enter any integer ({counter + 1} of 5): ");
                    double integer = double.Parse(Console.ReadLine());

                    max = Math.Max(max, integer);

                    ++counter;
                }

                Console.WriteLine($"The maximum of these numbers is {max}");
            }
        }
    }
}