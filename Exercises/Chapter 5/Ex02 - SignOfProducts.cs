using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter5
    {
        public static class Ex02_SignOfProducts
        {
            // Contains main solution code 
            public static void Solution()
            {
                double a = 3.55;
                double b = 4.80;
                double c = 25.39;

                Console.WriteLine("Expression: {0} x {1} x {2}", a, b, c);
                Console.Write("The sign of the result is? ");

                // Product of numbers will have a negative sign if the amount of numbers carrying a negative sign are odd. Otherwise it will
                // have a positive sign
                // The exercise specifically said to use a sequence of ifs and not to calculate
                if (a < 0 && b < 0 && c < 0)
                {
                    Console.WriteLine("Negative");
                }
                else if ((a < 0 && b < 0) || (a < 0 && c < 0) || (b < 0 && c < 0))
                {
                    Console.WriteLine("Positive");
                }
                else if (a < 0 || b < 0 || c < 0)
                {
                    Console.WriteLine("Negative");
                }
                else
                {
                    Console.WriteLine("Positive");
                }
            }
        }
    }


}