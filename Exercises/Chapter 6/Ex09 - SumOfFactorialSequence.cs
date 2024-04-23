using System;
using System.Numerics;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter6
    {
        public static class Ex09_SumOfFactorialSequence
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter n: ");
                int n = int.Parse(Console.ReadLine());

                Console.Write("Enter k: ");
                int k = int.Parse(Console.ReadLine());

                // Double is used instead of BigInteger because the result will not be an integer. Furthermore, it us used instead of
                // Decimal because it supports a wider range of values than decimal.
                double sum = 1.0 / 7;
                double factorial = 1;
                double power = k;

                for (int nth = 2; nth <= n; ++nth)
                {
                    factorial *= nth;
                    power *= k;
                    sum += factorial / power;
                }

                Console.WriteLine($"Sum of sequence: {sum}");
            }
        }
    }
}