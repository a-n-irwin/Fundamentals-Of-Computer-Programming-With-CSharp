using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter4
    {
        public static class Ex02_PerimeterAndAreaOfACircle
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter circle radius: ");
                double radius = double.Parse(Console.ReadLine());

                // The perimeter of a circle is its circumeference: circumeference = PI x diameter(or 2 x radius)
                // The area of a circle is PI x the radius squared
                double perimeter = Math.PI * 2 * radius;
                double area = Math.PI * radius * radius;

                // I've printed the output to at most 4 decimal places
                Console.WriteLine("Perimeter: {0:#.####}\nArea: {1:#.####}", perimeter, area);
            }
        }
    }
}