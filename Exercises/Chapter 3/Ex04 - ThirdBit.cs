using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter3
    {
        public static class Ex04_ThirdBit
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter an integer: ");
                int n = int.Parse(Console.ReadLine());

                // Third bit from the right (zero-based index).
                // true = 1, false = 0
                bool bit = ((n >> 3) & 1) == 1;
                // or 
                // bool bit = (n & (1 << 3)) != 0;
                Console.WriteLine($"third bit is {(bit ? 1 : 0)}");
            }
        }
    }
}