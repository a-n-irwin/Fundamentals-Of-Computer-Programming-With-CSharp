using System;


namespace FundamentalsOfComputerProgrammingWithCSharp;

partial class Chapter3
{
    public static void Ex04_ThirdBit()
    {
        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());

        // Third bit from the right (zero-based index).
        // true = 1, false = 0
        bool bit = ((n >> 3) & 1) == 1;
        // or 
        // bool bit = (n & (1 << 3)) != 0;
        Console.WriteLine($"third bit is {(bit ? 1 : 0)}");
    }
}