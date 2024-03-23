using System;


namespace FundamentalsOfComputerProgrammingWithCSharp;

partial class Chapter4
{
    public static void Ex01_SumOfThreeIntegers()
    {
        Console.Write("Enter three integers: ");
        string[] integers = Console.ReadLine().Split();

        int a = int.Parse(integers[0]);
        int b = int.Parse(integers[1]);
        int c = int.Parse(integers[2]);

        Console.WriteLine("sum: {0}", a + b + c);
    }
}