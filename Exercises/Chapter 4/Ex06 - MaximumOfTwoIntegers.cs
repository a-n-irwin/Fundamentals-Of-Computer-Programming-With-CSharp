using System;



namespace FundamentalsOfComputerProgrammingWithCSharp;



partial class Chapter4
{
    public static void Ex06_MaximumOfTwoIntegers()
    {
        Console.Write("Enter two integers: ");
        string[] input = Console.ReadLine().Split();

        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        int max = Math.Max(a, b);
        Console.WriteLine("Max: {0}", max);
    }
}