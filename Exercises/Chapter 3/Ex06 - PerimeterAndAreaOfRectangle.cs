using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter3
    {
        public static class Ex06_PerimeterAndAreaOfRectangle
        {
            // Contains main solution code 
            public static void Solution()
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
    }
}