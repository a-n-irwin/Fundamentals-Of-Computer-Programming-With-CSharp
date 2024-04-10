using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter4
    {
        public static class Ex04_ThreeNumbers
        {
            // Contains main solution code 
            public static void Solution()
            {
                int integer = 27;

                double fraction1 = 35.0 / 17;
                double fraction2 = -70.0 / 3;

                Console.WriteLine("0x{0, -8:X}{1, -10:F2}{2, -10:F2}", integer, fraction1, fraction2);
            }
        }
    }
}