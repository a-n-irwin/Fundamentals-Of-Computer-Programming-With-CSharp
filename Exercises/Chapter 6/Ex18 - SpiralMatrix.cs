using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter6
    {
        // I had to implement this solution on the spot because it was easier to code and adjust my code to make it work than do all
        // the thinking for it at once. 
        public static class Ex18_SpiralMatrix
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter n: ");
                int n = int.Parse(Console.ReadLine());

                int[,] matrix = new int[n, n];

                // In one loop iteration the numbers will be written around the perimeter of the current layer of the spiral. In a
                // 4x4 matrix, for instance there are two layers of the spiral: the first outter layer and the second inner layer. A 
                // layer, in this case, is the perimeter of the spiral or matrix, and each layer is one step into the spiral (I don't 
                // know if that makes any sense?). Also each layer has equal width and height and these dimensions are 2 less than the
                // preceeding layer, which is why the counter below is less 2 in each iteration.
                for (int count = n, number = 1, layer = 0; count > 0; count -= 2, ++layer)
                {
                    // Fill this layer's top
                    for (int col = layer; col < n - layer; ++col)
                        matrix[layer, col] = number++;

                    // Fill this layer's right
                    for (int row = layer + 1; row < n - layer; ++row)
                        matrix[row, n - layer - 1] = number++;

                    // Fill this layer's bottom
                    for (int col = n - layer - 2; col >= layer; --col)
                        matrix[n - layer - 1, col] = number++;

                    // Fill this layer's left
                    for (int row = n - layer - 2; row >= layer + 1; --row)
                        matrix[row, layer] = number++;
                }

                int width = $"{matrix.Length}".Length + 1;

                // Print the matrix
                for (int row = 0; row < n; ++row)
                {
                    for (int col = 0; col < n; ++col)
                    {
                        Console.Write($"{matrix[row, col]}".PadLeft(width));
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}