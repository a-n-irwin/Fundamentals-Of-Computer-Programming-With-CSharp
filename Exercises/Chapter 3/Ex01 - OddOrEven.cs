using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter3
    {
        public static class Ex01_OddOrEven
        {
            // Contains main solution code 
            public static void Solution()
            {
                int number = 136;
                bool isOdd = number % 2 != 0;

                Console.WriteLine($"{number} is " + (isOdd ? "odd." : "even."));
            }
        }
    }
}