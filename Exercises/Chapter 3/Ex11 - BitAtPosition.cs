using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter3
    {
        public static class Ex11_BitAtPosition
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter the integer and bit position: ");
                string[] input = Console.ReadLine().Split();

                int n = int.Parse(input[0]);
                int p = int.Parse(input[1]);

                // Get the bit at position p (zero based index position)
                int bit = (n >> p) & 1;
                Console.WriteLine($"bit at position {p} is {bit}");
            }
        }
    }
}