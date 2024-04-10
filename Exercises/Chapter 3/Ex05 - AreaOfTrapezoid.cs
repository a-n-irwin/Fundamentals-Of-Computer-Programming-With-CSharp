using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter
    {
        public static class Ex05_AreaOfTrapezoid
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter a, b and h respectively: ");
                string[] input = Console.ReadLine().Split();

                double a = double.Parse(input[0]);
                double b = double.Parse(input[1]);
                double h = double.Parse(input[2]);

                // Area = 1/2(a + b)h
                double area = 0.5 * (a + b) * h;

                Console.WriteLine($"\nTrapezoid\n  a: {a}\n  b: {b}\n  h: {h}\n  area: {area}");
            }
        }
    }
}