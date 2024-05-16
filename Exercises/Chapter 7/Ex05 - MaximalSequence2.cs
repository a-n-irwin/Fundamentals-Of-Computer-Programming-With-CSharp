using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter07
    {
        public static class Ex05_MaximalSequenceOfConsecutiveIncreasingIntegers
        {
            // Contains main solution code 
            public static void Solution()
            {
                int[] array = { 3, 2, 3, 4, 2, 4, 5, 2, 4 };
                // int[] array = { 3, 2, 3, 4, 2, 2, 4 };

                int index = 0;
                int count = 1;
                int sum = array[index];

                for (int i = 1, counter = 1, aggregate = sum; i < array.Length; ++i)
                {
                    if (array[i] - array[i - 1] >= 1)
                    {

                        aggregate += array[i];
                        counter++;
                    }
                    else
                    {
                        aggregate = array[i];
                        counter = 1;
                    }

                    if (aggregate >= sum)
                    {
                        if (aggregate == sum && counter >= count) continue;

                        index = i + 1 - counter;
                        count = counter;
                        sum = aggregate;
                    }

                }

                Console.WriteLine("The array: ");
                foreach (int item in array) Console.Write($"{item} ");

                Console.WriteLine("\n\nThe maximal sequence of consecutively increasing integers: ");
                for (int i = index; i < index + count; ++i) Console.Write($"{array[i]} ");

                Console.WriteLine($"\nThe sum: {sum}");
            }
        }
    }
}