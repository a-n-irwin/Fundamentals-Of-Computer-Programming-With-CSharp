using System;



namespace FundamentalsOfComputerProgrammingWithCSharp;



partial class Chapter4
{
    public static void Ex12_CalculationToPrecision()
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