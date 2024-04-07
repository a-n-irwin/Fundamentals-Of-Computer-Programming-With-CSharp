using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter1
    {
        public static class Ex11_AgeAfterTenYears
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("age: ");

                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Age after ten years: {0}", age + 10);
            }
        }
    }
}