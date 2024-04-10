using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter3
    {
        public static class Ex13_ChangeBitAtPosition
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter n and p: ");
                string[] input = Console.ReadLine().Split();
                int n = int.Parse(input[0]);
                int p = int.Parse(input[1]);

                Console.Write("Enter bit(0 or 1): ");
                int v = int.Parse(Console.ReadLine());

                // Validating input v 
                if (v != 0 && v != 1)
                {
                    Console.WriteLine("the target bit must be a value of 0 or 1");
                    return;
                }

                int bit = (n >> p) & 1;
                Console.WriteLine($"old bit at position {p}: {bit}");

                // Solution to the excersie
                n = (n & (~(1 << p))) ^ (v << p);

                // Not required, but just here to prove the bit changed to the one specified by v
                bit = (n >> p) & 1;

                Console.WriteLine($"new bit at position {p}: {bit}");
                Console.WriteLine($"new value of n: {n}");
            }
        }
    }
}