using System;


namespace Fundamentals_Of_Computer_Programming_With_CSharp;

partial class Chapter3
{
    public static void Ex04_ThirdBit()
    {
        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());

        // Third bit from the right. I take third bit to be the bit at the second (zero-based) index
        // true = 1, false = 0
        bool bit = ((n >> 2) & 1) == 1;
        // or 
        // bool bit = (n & (1 << 2)) != 0;
        Console.WriteLine($"third bit is {(bit ? 1 : 0)}");
    }
}