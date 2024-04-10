using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter3
    {
        public static class Ex03_ThirdDigit
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter an integer: ");
                int n = int.Parse(Console.ReadLine());

                bool thirdDigitIsSeven = (n % 1000) / 100 == 7;

                Console.WriteLine($"Third digit is 7? {thirdDigitIsSeven}");
            }
        }
    }
}