using System;
using System.Numerics;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter6
    {
        // Slight modiification of exercise 6
        public static class Ex07_FactorialExpression2_Alt
        {
            // Contains main solution code 
            public static void Solution()
            {
                // The goal is to calculate N!/K! for given N and K (1 < K < N).
                int n = 0;
                int k = 0;

                bool condition = true;

                // Persistent input prompt
                while (condition)
                {
                    Console.Write("Enter N: ");
                    n = int.Parse(Console.ReadLine());

                    Console.Write("Enter K: ");
                    k = int.Parse(Console.ReadLine());

                    condition = 1 <= n && n <= k;
                    // Input validation
                    if (condition)
                    {
                        Console.WriteLine("\nInvalid entery: N must be greater than K and K must be greater than 1 (i.e 1 < K < N)\n");
                    }
                }

                // N! * K! / (N - K)!
                BigInteger result = n;

                for (int i = n - 1; i > (n - k); --i) result *= i;
                for (int i = k; i > 1; --i) result *= i;

                Console.WriteLine("N! * K! / (N - K)! = {0:N0}", result);
            }
        }
    }
}