using System;


namespace Fundamentals_Of_Computer_Programming_With_CSharp;

partial class Chapter3
{
    public static void Ex07_WeightOnMoon()
    {
        Console.Write("Enter weight on earth: ");
        double w = int.Parse(Console.ReadLine());

        // 17 % of the weight which obtains on earth
        double weightOnMoon = 0.17 * w;

        // The weight is printed to 2 decimal places
        Console.WriteLine($"weight on moon: {weightOnMoon:0.00}");
    }
}