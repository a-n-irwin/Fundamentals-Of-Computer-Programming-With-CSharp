using System;


namespace FundamentalsOfComputerProgrammingWithCSharp;


partial class Chapter3
{
    public static void Ex10_FourDigitOperation()
    {
        Console.Write("Enter a four-digit integer: ");
        string input = Console.ReadLine();

        // Make sure it's a four-digit integer
        if (input.Length != 4)
        {
            Console.Write("Not a four-digit integer");
            return;
        }

        int num = int.Parse(input);
        int a = num / 1000;
        int b = (num % 1000) / 100;
        int c = (num % 100) / 10;
        int d = num % 10;


        Console.WriteLine($"sum: {a + b + c + d}");
        Console.WriteLine($"reversed: {d}{c}{b}{a}");
        Console.WriteLine($"last digit as first: {d}{a}{b}{c}");
        Console.WriteLine($"swap second and third digits: {a}{c}{b}{d}");
    }
}