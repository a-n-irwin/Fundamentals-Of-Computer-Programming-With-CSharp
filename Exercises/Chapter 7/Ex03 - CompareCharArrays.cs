using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter07
    {
        public static class Ex03_ComapreCharArrays
        {
            // Contains main solution code 
            public static void Solution()
            {
                char[][] arrays = {
                    new char[]{'g', 'e', 'o', 'r', 'g', 'i', 'a'},
                    new char[]{'G', 'e', 'o', 'r', 'g', 'i', 'e'}
                };

                int length = Math.Min(arrays[0].Length, arrays[1].Length);

                // An index of zero assumes the first array, arrays[0], is first in lexicographical order
                int index = 0;

                // Compare the char arrays lexicographically
                for (int i = 0; i < length; ++i)
                {
                    if (Char.ToLower(arrays[0][i]) > Char.ToLower(arrays[1][i]))
                    {
                        index = 1;
                        break;
                    }
                }

                // Print the arrays:
                int counter = 1;
                foreach (char[] array in arrays)
                {
                    Console.Write("Array {0}: ", counter++);

                    foreach (char item in array) Console.Write($"{item} ");

                    Console.WriteLine();
                }

                Console.WriteLine("The {0} array comes first lexicographically", index == 0 ? "first" : "second");
            }
        }
    }
}