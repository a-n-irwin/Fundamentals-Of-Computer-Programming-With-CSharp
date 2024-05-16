using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter07
    {
        // LOL! What was I even supposed to name this exercise?
        public static class Ex11_SequenceOfNeighbourElements
        {
            // Contains main solution code 
            public static void Solution()
            {
                int[] array = { 4, 3, 1, 4, 2, 5, 8 };
                int sum = 17;

                int index = -1;
                int count = 0;

                for (int position = 0; position < array.Length; ++position)
                {
                    for (int i = position, aggregate = 0; i < array.Length; ++i)
                    {
                        aggregate += array[i];
                        // We want to stop as soon as we find a subsequence which gives us the required
                        if (aggregate == sum)
                        {
                            index = position;
                            count = i + 1 - position;

                            break;
                        }
                    }
                }

                // Print the array
                Console.WriteLine("The array: ");
                foreach (int element in array) Console.Write($"{element} ");

                // Print the subsequence
                if (index != -1)
                {
                    Console.WriteLine($"\n\nThe subsequence which yields a sum of {sum} is: ");
                    for (int i = index; i < index + count; ++i) Console.Write($"{array[i]} ");
                }
                else Console.WriteLine($"\n\nThe subsequence which yields a sum of {sum} does not exist in this array.");
            }
        }
    }
}