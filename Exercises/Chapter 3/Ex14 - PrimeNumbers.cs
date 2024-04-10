using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter3
    {
        public static class Ex14_PrimeNumbers
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter an integer in the range 1 - 100: ");
                int n = int.Parse(Console.ReadLine());

                // Input validation: 1 < n < 100
                if (n >= 100 || n <= 1)
                {
                    Console.WriteLine($"{n} is not within range");
                    return;
                }

                bool isPrime = true;
                int length = (int)Math.Sqrt(n);

                for (int i = 2; i <= length; ++i)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine($"{n} is prime? {isPrime}");
            }
        }
    }
}