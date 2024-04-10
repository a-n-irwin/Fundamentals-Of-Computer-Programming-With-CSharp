using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter2
    {
        public static class Ex13_SwapTwoIntegers
        {
            // Contains main solution code 
            public static void Solution()
            {
                int a = 5;
                int b = 10;

                Console.WriteLine($"Before swap:\na: {a}\nb: {b}");

                int temp = a;
                a = b;
                b = temp;

                // See also:
                // a = a + b;
                // b = a - b;
                // a = a - b;

                // See also:
                // (a, b) = (b, a);

                Console.WriteLine($"After swap:\na: {a}\nb: {b}");
            }
        }
    }
}