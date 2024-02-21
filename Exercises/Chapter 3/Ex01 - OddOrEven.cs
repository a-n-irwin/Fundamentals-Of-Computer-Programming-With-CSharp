using System;


namespace Fundamentals_Of_Computer_Programming_With_CSharp;

partial class Chapter3
{
    public static void Ex01_OddOrEven()
    {
        int number = 136;
        bool isOdd = number % 2 != 0;

        Console.WriteLine($"{number} is " + (isOdd ? "odd." : "even."));
    }
}