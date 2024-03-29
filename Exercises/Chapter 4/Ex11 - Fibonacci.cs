using System;



namespace FundamentalsOfComputerProgrammingWithCSharp;



partial class Chapter4
{
    public static void Ex11_Fibonacci()
    {
        // The first two terms of the fibonacci sequence
        decimal prev = 0;
        decimal next = 1;

        Console.Write($"{prev}, {next}");

        // We've already accounted for the first two numbers of the sequence above
        for (int index = 2; index < 100; index++)
        {
            // I placed it in a checked block to find out which data type could contain the results
            checked
            {
                decimal temp = next;
                next = prev + next;
                prev = temp;

                Console.Write($", {next}");
            }
        }
    }
}