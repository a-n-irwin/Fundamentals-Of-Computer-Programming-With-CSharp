using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter4
    {
        public static class Ex12_CalculationToPrecision
        {
            // Contains main solution code 
            public static void Solution()
            {
                double oldSum = 1;
                double newSum = oldSum + 1.0 / 2;

                int denominator = 3;


                while (Math.Abs(newSum - oldSum) > 1E-3)
                {
                    oldSum = newSum;
                    newSum += 1.0 / (denominator % 2 == 0 ? denominator++ : -denominator++);
                }

                // Displayed to 3 decimal places
                Console.WriteLine($"Sum: {newSum:F3}");
            }
        }
    }
}