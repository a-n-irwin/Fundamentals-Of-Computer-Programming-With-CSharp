using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter6
    {
        public static class Ex10_Matrix
        {
            // Contains main solution code 
            public static void Solution()
            {
                int n = 0;
                bool condition = true;

                // Persistent input prompt:
                while (condition)
                {
                    Console.Write("Enter n (1 - 20): ");
                    condition = !(int.TryParse(Console.ReadLine(), out n) && (n >= 1 && n <= 20));

                    if (condition)
                    {
                        Console.WriteLine("Invalid input: Please enter a valid integer within the range 1 - 20");
                    }
                }

                for (int row = 1; row <= n; ++row)
                {
                    for (int col = row; col < (n + row); ++col)
                    {
                        Console.Write($"{col,2} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}