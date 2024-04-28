using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter6
    {
        public static class Ex17_GCDAndLCM
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter two integers: ");
                string[] integers = Console.ReadLine().Split();

                int a = int.Parse(integers[0]);
                int b = int.Parse(integers[1]);

                int gcd = GCD(a, b);
                int lcm = a * b / gcd;

                Console.WriteLine($"The GCD is: {gcd}\nThe LCM is {lcm}");
            }

            static int GCD(int a, int b)
            {
                int gcd = 1;
                for (int divisor = Math.Min(a, b); divisor > 1; --divisor)
                {
                    if ((a % divisor == 0) && (b % divisor == 0)) return divisor;
                }
                return gcd;
            }
        }
    }
}