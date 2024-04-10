using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter3
    {
        public static class Ex16_SwapKBits
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter n, p, and q: ");
                string[] input = Console.ReadLine().Split();

                uint n = uint.Parse(input[0]);
                int p = int.Parse(input[1]);
                int q = int.Parse(input[2]);

                Console.Write("Enter k: ");
                int k = int.Parse(Console.ReadLine());

                for (int i = 0; i < k; ++i)
                {
                    Console.WriteLine($"bit at position {p + i} (before swapping): {GetBit(n, p + i)}");
                    Console.WriteLine($"bit at position {q + i} (before swapping): {GetBit(n, q + i)}");

                    n = SwapBits(n, p + i, q + i);

                    Console.WriteLine($"bit at position {p + i} (after swapping): {GetBit(n, p + i)}");
                    Console.WriteLine($"bit at position {q + i} (after swapping): {GetBit(n, q + i)}\n");
                }

                Console.WriteLine($"value of n after swapping: {n}");
            }

            public static uint SwapBits(uint n, int p1, int p2)
            {
                // If the two bits to swap are not the same, flip them. Else, return the number as is
                if (GetBit(n, p1) != GetBit(n, p2))
                {
                    n ^= 1u << p1;
                    n ^= 1u << p2;
                }
                return n;
            }

            // Position, p, is zero-based
            static uint GetBit(uint n, int p) => (n >> p) & 1;
        }
    }
}