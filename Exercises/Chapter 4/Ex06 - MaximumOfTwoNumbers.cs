using System;



namespace FundamentalsOfComputerProgrammingWithCSharp;



partial class Chapter4
{
    public static void Ex06_MaximumOfTwoNumbers()
    {
        Console.Write("Enter two integers: ");
        string[] input = Console.ReadLine().Split();

        double a = double.Parse(input[0]);
        double b = double.Parse(input[1]);

        double max = Math.Max(a, b);
        Console.WriteLine("Max: {0}", max);
    }
}