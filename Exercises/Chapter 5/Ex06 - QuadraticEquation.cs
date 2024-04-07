using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter5
    {
        public static class Ex06_QuadraticEquation
        {
            public static void solution()
            {
                Console.WriteLine("Enter the coefficients a, b, c of the quadratic equation below\nQuadratic equation: ax^2 + bx + c\n");

                Console.Write("Enter coefficient a: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Enter coefficient b: ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("Enter coefficient c: ");
                double c = double.Parse(Console.ReadLine());

                double root1 = 0;
                double root2 = 0;

                // When solving using the quadratic formula, it is possible to arrive at a negative square root, at which point it would be 
                // impossible to proceed. So, first we make sure to check that this is not the case
                double discriminant = Math.Pow(b, 2) - 4 * a * c;

                if (discriminant == 0)
                {
                    root1 = root2 = -b / (2 * a);
                }
                else if (discriminant > 0)
                {
                    root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                }
                else
                {
                    root1 = root2 = Double.NaN;
                }

                Console.WriteLine("\nRoots of the quadratic equation: ");
                Console.WriteLine("Root 1: {0}\nRoot 2: {1}", Math.Round(root1, 3), Math.Round(root2, 3));

            }
        }
    }
}