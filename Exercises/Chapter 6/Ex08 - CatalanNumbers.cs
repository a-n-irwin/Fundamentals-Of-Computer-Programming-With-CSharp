using System;
using System.Numerics;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter6
    {
        public static class Ex08_CatalanNumbers
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter n: ");
                int n = int.Parse(Console.ReadLine());

                BigInteger numerator = 1;
                BigInteger denominator = 1;

                for (int counter = 0, numeratorN = 2 * n, denominator_multiplier = n; counter < n - 1; ++counter)
                {
                    numerator *= numeratorN--;
                    denominator *= denominator_multiplier--;
                }

                Console.WriteLine($"Nth({n}) Catalan number: {numerator / denominator}");
            }
        }
    }
}