using System;


namespace FundamentalsOfComputerProgrammingWithCSharp;

partial class Chapter3
{
    public static void Ex06_PerimeterAndAreaOfRectangle()
    {
        Console.Write("Enter width and height respectively: ");
        string[] input = Console.ReadLine().Split();

        double w = double.Parse(input[0]);
        double h = double.Parse(input[1]);

        double perimeter = 2 * (w + h);
        double area = w * h;

        Console.WriteLine($"\nRectangle\n  width:  {w}\n  height: {h}\n  perimeter: {perimeter}\n  area: {area}");
    }
}