using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter3
    {
        public static class Ex12_BitAtPosition
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter the integer and bit position: ");
                string[] input = Console.ReadLine().Split();

                int v = int.Parse(input[0]);
                int p = int.Parse(input[1]);

                // Get the bit at position p. I assume "p" is a zero based index position (the illustration suggests so)
                bool bit = ((v >> p) & 1) == 1;
                Console.WriteLine($"bit at position {p} is 1? {bit}");
            }
        }
    }
}