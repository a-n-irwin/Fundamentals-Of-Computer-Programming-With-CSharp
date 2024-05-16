using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter07
    {
        public static class Ex09_SubsequenceWithMaximalSum
        {
            // Contains main solution code 
            public static void Solution()
            {
                int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

                int index = 0;
                int sum = array[index];
                int count = 1;

                for (int position = 0; position < array.Length; ++position)
                {
                    for (int i = position, aggregate = 0; i < array.Length; ++i)
                    {
                        aggregate += array[i];

                        if (aggregate >= sum)
                        {
                            if (aggregate == sum && (i + 1 - position) >= count) continue;

                            index = position;
                            sum = aggregate;
                            count = i + 1 - position;
                        }
                    }
                }

                Console.WriteLine(count);

                // Print the array
                Console.WriteLine("The array: ");
                foreach (int item in array) Console.Write($"{item} ");

                // Print the subsequence and the sum
                Console.WriteLine("\n\nThe subsequence with maximal sum: ");
                for (int i = index; i < index + count; ++i) Console.Write($"{array[i]} ");

                Console.WriteLine($"\nSum: {sum}");
            }
        }
    }
}