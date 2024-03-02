using System;


namespace FundamentalsOfComputerProgrammingWithCSharp;

partial class Chapter1
{
    public static void Ex11_AgeAfterTenYears()
    {
        Console.Write("age: ");

        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Age after ten years: {0}", age + 10);
    }
}
