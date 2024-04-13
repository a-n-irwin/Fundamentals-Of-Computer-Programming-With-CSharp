using System;
using System.Numerics;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter6
    {
        public static class Ex05_SumOfFibonacciSequence
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter N: ");
                int n = int.Parse(Console.ReadLine());

                // The first two terms of the fibonacci sequence
                BigInteger prev = 0;
                BigInteger next = 1;

                BigInteger sum = n <= 1 ? 0 : 1;

                // We've already accounted for the first two numbers of the sequence above
                for (int nth = 3; nth <= n; ++nth)
                {
                    // Updates the values in prev and next to the resulting evaluation on the RHS of the expression
                    (prev, next) = (next, prev + next);
                    sum += next;
                }

                Console.WriteLine("Sum of the first {0} elements in the fibonacci sequence: {1}", n, sum);
            }
        }
    }
}