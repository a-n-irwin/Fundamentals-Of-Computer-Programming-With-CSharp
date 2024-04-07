using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter5
    {
        public static class Ex01_ConditionalIntegerSwapping
        {
            // Contains main solution code 
            public static void Solution()
            {
                int firstInteger = -5;
                int secondInteger = 3;

                bool condition = firstInteger > secondInteger;

                // For illustration purposes
                Console.WriteLine("first int: {0}\nsecond int: {1}", firstInteger, secondInteger);
                Console.WriteLine("{0} > {1}? {2}", firstInteger, secondInteger, condition);

                // Swaps the values if condition is true
                if (condition)
                {
                    int temp = firstInteger;
                    firstInteger = secondInteger;
                    secondInteger = temp;
                }

                // For illustration purposes
                Console.WriteLine("first int: {0}\nsecond int: {1}", firstInteger, secondInteger);
            }
        }
    }


}
