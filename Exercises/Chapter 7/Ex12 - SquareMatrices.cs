using System;
using System.IO;
using System.Reflection.Metadata;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter07
    {
        public static class Ex12_SquareMatrices
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter matrix size: ");
                int size = int.Parse(Console.ReadLine());

                int[][,] matrices = new int[4][,];

                matrices[0] = new int[size, size];
                matrices[1] = new int[size, size];
                matrices[2] = new int[size, size];
                matrices[3] = new int[size, size];

                int length = size * size;

                // Variables for the third array
                // Indicates where on the third array the diagonal movement is to start from
                int[] origin = { size - 1, 0 };

                // The current position of the row and column, along the diagonal, to write the current number
                int row_ = origin[0];
                int col_ = origin[1];

                // Generating the first three arrays
                for (int index = 0; index < length; ++index, ++row_, ++col_)
                {
                    int row = index % size;
                    int col = index / size;

                    // If boundaries are reached
                    if (row_ == size || col_ == size)
                    {
                        // It must be done in this order, so that the column update uses the old value of origin[0]
                        col_ = origin[1] = origin[0] == 0 ? origin[1] + 1 : 0;
                        row_ = origin[0] = Math.Max(origin[0] - 1, 0);
                    }

                    // Update the first, second and third arrays
                    matrices[0][row, col] = matrices[1][col % 2 == 0 ? row : size - 1 - row, col] = matrices[2][row_, col_] = index + 1;
                }

                // Generating the fourth array
                // This is simply a slight adaptation of the Spiral Matrix solution from chapter 6
                for (int count = size, number = 1, layer = 0; count > 0; count -= 2, ++layer)
                {
                    // Fill this layer's left
                    for (int row = layer; row < size - layer; ++row)
                        matrices[3][row, layer] = number++;

                    // Fill this layer's bottom
                    for (int col = layer + 1; col < size - layer; ++col)
                        matrices[3][size - 1 - layer, col] = number++;

                    // Fill this layer's right
                    for (int row = size - 2 - layer; row >= layer; --row)
                        matrices[3][row, size - 1 - layer] = number++;

                    // Fill this layer's top
                    for (int col = size - 2 - layer; col > layer; --col)
                        matrices[3][layer, col] = number++;
                }


                PrintMatrix(matrices[0]);
                PrintMatrix(matrices[1]);
                PrintMatrix(matrices[2]);
                PrintMatrix(matrices[3]);
            }

            private static void PrintMatrix(int[,] matrix)
            {
                int width = $"{matrix.Length}".Length + 1;

                for (int row = 0; row < matrix.GetLength(0); ++row)
                {
                    for (int col = 0; col < matrix.GetLength(1); ++col)
                    {
                        Console.Write($"{matrix[row, col]}".PadLeft(width));
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}