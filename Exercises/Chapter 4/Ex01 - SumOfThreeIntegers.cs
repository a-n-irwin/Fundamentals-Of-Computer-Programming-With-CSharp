using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter4
    {
        public static class Ex01_SumOfThreeIntegers
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter three integers: ");
                string[] integers = Console.ReadLine().Split();

                int a = int.Parse(integers[0]);
                int b = int.Parse(integers[1]);
                int c = int.Parse(integers[2]);

                Console.WriteLine("sum: {0}", a + b + c);
            }
        }
    }
}