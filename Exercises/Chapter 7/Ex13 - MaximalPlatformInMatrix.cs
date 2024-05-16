using System;
using System.IO;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter07
    {
        public static class Ex13_MaximalPlatformInMatrix
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.WriteLine("Enter matrix dimensions");
                Console.Write("Enter m: ");
                int m = int.Parse(Console.ReadLine());

                Console.Write("Enter n: ");
                int n = int.Parse(Console.ReadLine());

                int[,] matrix = new int[m, n];

                // Read the matrix
                Console.WriteLine("\nEnter the values for the matrix row by row below");
                for (int row = 0; row < m; ++row)
                {
                    Console.WriteLine($"Row {row + 1}");
                    for (int col = 0; col < n; ++col)
                    {
                        Console.Write($"Column {col + 1}: ");
                        matrix[row, col] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine();
                }

                // Find a 3x3 platform in the matrix with maximal sum:
                int[,] submatrix = new int[3, 3];
                int sum = int.MinValue;

                // The row and column where the platform starts from
                int[] origin = { 0, 0 };

                for (int row = 0; row < m - 2; ++row)
                {
                    for (int col = 0; col < n - 2; ++col)
                    {
                        // The sum of all nine elements of the 3x3 sub-matrix
                        int aggregate = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                        if (aggregate > sum)
                        {
                            sum = aggregate;
                            origin[0] = row;
                            origin[1] = col;
                        }
                    }
                }

                // Print the maximal platform:
                Console.WriteLine("The maximal platform is: ");
                for (int row = origin[0]; row < origin[0] + 3; ++row)
                {
                    for (int col = origin[1]; col < origin[1] + 3; ++col)
                    {
                        Console.Write($"{matrix[row, col]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"The sum is {sum}");
            }
        }
    }
}