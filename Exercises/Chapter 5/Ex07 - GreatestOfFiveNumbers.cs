using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{



    namespace Chapter5
    {
        // This solution is exactly the same as the one for Chapter 4 exercise 8
        public static class Ex07_GreatestOfFiveNumbers
        {
            public static void Solution()
            {
                int counter = 0;
                double greatest = 0;

                while (counter < 5)
                {
                    Console.Write($"Enter any integer ({counter + 1} of 5): ");
                    double integer = double.Parse(Console.ReadLine());

                    greatest = Math.Max(greatest, integer);

                    ++counter;
                }

                Console.WriteLine($"The greatest of these numbers is {greatest}");
            }
        }
    }
}