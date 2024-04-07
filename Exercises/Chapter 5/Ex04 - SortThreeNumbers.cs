using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter5
    {
        public static class Ex04_SortThreeNumbers
        {
            // Contains main solution code 
            public static void Solution()
            {
                double a = 5.35;
                double b = -13.5;
                double c = 3.0;

                // Variables to store the sorted values: from highest to lowest
                double d = a;
                double e = b;
                double f = c;

                Console.WriteLine($"Numbers: {a}, {b}, {c}");

                // While this exercise required the use of nested ifs, my poor brain could not handle the complexity it brought, so I went
                // with the suggested solution from the book. The funny thing is none of the suggested solutions from the book used nested 
                // ifs. Of course I know the permutations (6 permutaions) but organizing that in a nested if statement made my brain cry - I 
                // could not do it. So: 

                // abc
                if (a >= b && b >= c)
                {
                    d = a;
                    e = b;
                    f = c;
                }
                // acb
                else if (a >= c && c >= b)
                {
                    d = a;
                    e = c;
                    f = b;
                }
                // bac
                else if (b >= a && a >= c)
                {
                    d = b;
                    e = a;
                    f = c;
                }
                // bca
                else if (b >= c && c >= a)
                {
                    d = b;
                    e = c;
                    f = a;
                }
                // cab
                else if (c >= a && a >= b)
                {
                    d = c;
                    e = a;
                    f = b;
                }
                // cba
                else if (c >= b && b >= a)
                {
                    d = c;
                    e = b;
                    f = a;
                }

                // Must be printed in the order d, e, f:
                Console.Write("Sorted (desc.): {0}, {1}, {2}", d, e, f);
            }
        }
    }
}