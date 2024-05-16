using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter07
    {
        public static class Ex08_SelectionSort
        {
            // Contains main solution code 
            public static void Solution()
            {
                int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

                Console.Write("Before sorting:\nArray -> ");

                foreach (int element in array) Console.Write($"{element} ");

                // Sort the array using selection sort algorithm
                for (int index = 0; index < array.Length - 1; ++index)
                {
                    // Assume the first element of the unsorted portion of the array is the minimum
                    int minIndex = index;

                    for (int i = index + 1; i < array.Length; ++i)
                    {
                        if (array[i] < array[minIndex]) minIndex = i;
                    }
                    // Swap the value at the first unsorted position with the minimum element
                    (array[index], array[minIndex]) = (array[minIndex], array[index]);
                }

                Console.Write("\n\nAfter sorting:\nArray -> ");

                foreach (int element in array) Console.Write($"{element} ");
            }
        }
    }
}