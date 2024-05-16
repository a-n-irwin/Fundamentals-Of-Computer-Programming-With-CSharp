using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter07
    {
        public static class Ex10_ModeOfADistrubution
        {
            // Contains main solution code 
            public static void Solution()
            {
                int?[] data = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

                int? mode = data[0];
                int count = 1;

                // Print the array first, because it will be modified
                Console.WriteLine($"The array: ");
                foreach (int? item in data) Console.Write($"{item} ");

                for (int index = 0; index < data.Length; ++index)
                {
                    // Skip all nulled-out numbers
                    if (data[index] == null) continue;

                    int counter = 0;

                    for (int i = 0; i < data.Length; ++i)
                    {
                        if (data[i] == data[index])
                        {
                            ++counter;
                            // Null the copies only, so we don't meet them at a subsequent iteration of the first loop
                            data[i] = counter > 1 ? null : data[i];
                        }

                    }
                    // Check if we found a greater count for the current item in this operation
                    if (counter > count)
                    {
                        mode = data[index];
                        count = counter;
                    }
                }

                // Print the result
                Console.WriteLine($"\n\nThe most occuring element is {mode}({count} times)");
            }
        }
    }
}