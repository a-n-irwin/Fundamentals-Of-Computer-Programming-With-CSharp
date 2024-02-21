using System;


namespace Fundamentals_Of_Computer_Programming_With_CSharp;

partial class Chapter2
{
    public static void Ex13_SwapTwoIntegers()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine($"Before swap:\na: {a}\nb: {b}");

        int temp = a;
        a = b;
        b = temp;

        // See also:
        // a = a + b;
        // b = a - b;
        // a = a - b;

        // See also:
        // (a, b) = (b, a);

        Console.WriteLine($"After swap:\na: {a}\nb: {b}");
    }
}