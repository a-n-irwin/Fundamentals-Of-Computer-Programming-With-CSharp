using System;
using FundamentalsOfComputerProgrammingWithCSharp.Chapter5;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter07
    {
        public static class Ex02_ArrayEquality
        {
            // Contains main solution code 
            public static void Solution()
            {
                int[][] arrays = new int[2][];

                // Assume the arrays will be equal
                bool isEqual = true;

                // Read the arrays from the console
                for (int counter = 0; counter < arrays.Length; ++counter)
                {
                    Console.Write($"\nEnter array {counter + 1} size: ");
                    int size = int.Parse(Console.ReadLine());

                    // Allocate the actual array for this operation
                    arrays[counter] = new int[size];

                    Console.WriteLine($"Enter elements of array {counter + 1} below (separate items by a single space character): ");

                    string[] input = Console.ReadLine().Split();
                    // If the user enters much more or less input that specified in the array size
                    // This validation is necessitated by the flaw which exists from using the above method to get inputs
                    if (input.Length != size)
                    {
                        Console.WriteLine($"The number of inputs ({input.Length}) entered does not match the specified size of {size}.\nPlease restart the program.");
                        Console.Read();
                        return;
                    }

                    for (int i = 0; i < arrays[counter].Length; ++i) arrays[counter][i] = int.Parse(input[i]);
                }

                // Check for equality of arrays:
                // Condition for equality: 
                // arrayA.Length = arrayB.Length and arrayA[i] = arrayB[i], where i = 0 to arrayA.Length - 1 and
                // arrayB.Length - 1, respectively
                if (isEqual = arrays[0].Length == arrays[1].Length)
                {
                    for (int i = 0; i < arrays[0].Length; ++i)
                    {
                        if (arrays[0][i] != arrays[1][i])
                        {
                            isEqual = false;
                            break;
                        }
                    }
                }

                Console.WriteLine("The arrays are {0}", isEqual ? "Equal" : "NOT Equal");
            }
        }
    }
}