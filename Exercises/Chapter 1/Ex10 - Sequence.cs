using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter1
    {
        public static class Ex10_Sequence
        {
            // Contains main solution code 
            public static void Solution()
            {
                for (int i = 0; i < 100; ++i)
                {
                    int n = i + 2;

                    System.Console.Write(n % 2 == 0 ? n : -n);
                    System.Console.Write(i < 99 ? ", " : ".");
                }
            }
        }
    }
}