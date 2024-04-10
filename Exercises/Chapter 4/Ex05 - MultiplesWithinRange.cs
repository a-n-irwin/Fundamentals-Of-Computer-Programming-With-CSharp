using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter4
    {
        public static class Ex05_MultiplesWithinRange
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter lower bound: ");
                int lowerBound = int.Parse(Console.ReadLine());

                Console.Write("Enter upper bound: ");
                int upperBound = int.Parse(Console.ReadLine());

                // Adjust the lower bound so the range starts at an integer which is a multple of 5
                lowerBound += 5 - (lowerBound % 5);

                // Adjust the upper bound so the range ends at an integer which is a multiple of 5
                upperBound -= upperBound % 5;

                // The amount of multiples of 5 between the range provided
                int multiples = (upperBound - lowerBound) / 5 + 1;

                Console.WriteLine("Numbers within this range divisible by 5: {0} numbers", multiples);
            }
        }
    }
}