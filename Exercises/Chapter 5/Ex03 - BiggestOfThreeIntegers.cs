using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter5
    {
        public static class Ex03_BiggestOfThreeIntegers
        {
            public static void Solution()
            {
                int a = -5;
                int b = 3;
                int c = 2;

                // Assume the first integer, a, is the biggest
                int biggest = a;

                // The exercise specifically required the use of nested if statements
                if (biggest < b)
                {
                    biggest = b;
                    if (biggest < c)
                    {
                        biggest = c;
                    }
                }
                else if (biggest < c)
                {
                    biggest = c;
                }

                Console.WriteLine("Numbers: {0}, {1}, {2}\nBiggest: {3}", a, b, c, biggest);
            }
        }
    }


}