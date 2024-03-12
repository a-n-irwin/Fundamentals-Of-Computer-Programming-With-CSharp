using System;


namespace FundamentalsOfComputerProgrammingWithCSharp;

partial class Chapter3
{
    public static void Ex15_SwapThreeBits()
    {
        Console.Write("Enter integer: ");
        uint n = uint.Parse(Console.ReadLine());

        // Print the bit values before swapping
        Console.WriteLine("\nbefore swapping: ");
        Console.WriteLine($"bit at position 3:  {GetBit(n, 3)}");
        Console.WriteLine($"bit at position 4:  {GetBit(n, 4)}");
        Console.WriteLine($"bit at position 5:  {GetBit(n, 5)}");
        Console.WriteLine($"bit at position 24: {GetBit(n, 24)}");
        Console.WriteLine($"bit at position 25: {GetBit(n, 25)}");
        Console.WriteLine($"bit at position 26: {GetBit(n, 26)}");


        // This is where the actual solution to the exercise is
        n = SwapBits(n, 3, 24);
        n = SwapBits(n, 4, 25);
        n = SwapBits(n, 5, 26);

        // Print the bit values after swapping
        Console.WriteLine("\nafter swapping: ");
        Console.WriteLine($"bit at position 3:  {GetBit(n, 3)}");
        Console.WriteLine($"bit at position 4:  {GetBit(n, 4)}");
        Console.WriteLine($"bit at position 5:  {GetBit(n, 5)}");
        Console.WriteLine($"bit at position 24: {GetBit(n, 24)}");
        Console.WriteLine($"bit at position 25: {GetBit(n, 25)}");
        Console.WriteLine($"bit at position 26: {GetBit(n, 26)}");

        Console.WriteLine($"n: {n}");
    }

    public static uint SwapBits(uint n, int p1, int p2)
    {
        // If the two bits to swap are not the same, flip them. Else, return the number as is
        if (GetBit(n, p1) != GetBit(n, p2))
        {
            n ^= 1u << p1;
            n ^= 1u << p2;
        }
        return n;
    }

    // Position, p, is zero-based
    static uint GetBit(uint n, int p) => (n >> p) & 1;
}