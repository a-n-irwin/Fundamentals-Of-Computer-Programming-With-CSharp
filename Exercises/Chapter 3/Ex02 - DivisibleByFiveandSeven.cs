using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter3
    {
        public static class Ex02_DivisibleByFiveAndSeven
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter an integer: ");
                int n = int.Parse(Console.ReadLine());

                int lcm5n7 = 35;

                bool isDivisible = n % lcm5n7 == 0;

                Console.WriteLine($"{n} is divisible by 5 and 7? {isDivisible}");
            }
        }
    }
}