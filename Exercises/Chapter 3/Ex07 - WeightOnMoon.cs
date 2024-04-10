using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter3
    {
        public static class Ex07_WeightOnMoon
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter weight on earth: ");
                double w = int.Parse(Console.ReadLine());

                // 17 % of the weight which obtains on earth
                double weightOnMoon = 0.17 * w;

                // The weight is printed to 2 decimal places
                Console.WriteLine($"weight on moon: {weightOnMoon:0.00}");
            }
        }
    }
}