using System;



namespace FundamentalsOfComputerProgrammingWithCSharp;



partial class Chapter4
{
    public static void Ex10_PrintNumbers()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        for (int integer = 1; integer <= n; ++integer)
        {
            Console.WriteLine(integer);
        }
    }
}