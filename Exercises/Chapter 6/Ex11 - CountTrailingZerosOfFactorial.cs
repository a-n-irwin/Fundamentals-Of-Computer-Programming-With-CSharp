using System;
using System.Numerics;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter6
    {
        public static class Ex11_CountTrailingZerosOfFactorial
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter a positive integer: ");
                int n = int.Parse(Console.ReadLine());

                BigInteger? factorial = Factorial(n);
                BigInteger? factorialCopy = factorial;

                int count = 0;

                while (factorialCopy % 10 == 0)
                {
                    count++;
                    factorialCopy /= 10;
                }

                Console.Write("\nFactorial: {0}\nNumber of trailing zeros: {1}", factorial, count);
            }

            static BigInteger? Factorial(int n)
            {
                if (n < 0) return null;

                BigInteger result = 1;

                while (n >= 2) result *= n--;

                return result;
            }
        }
    }
}