using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter6
    {
        public static class Ex03_SmallestAndLargestInteger
        {
            // Contains main solution code 
            public static void Solution()
            {
                // The code did not specify how many inputs there would be
                Console.Write("Enter the number of entries: ");
                int n = int.Parse(Console.ReadLine());

                int smallest = int.MaxValue;    // So it can become smaller during comparison with entries
                int largest = int.MinValue;     // So it can become larger during comparison with entries

                for (int i = 0; i < n; ++i)
                {
                    Console.Write($"Enter integer ({i + 1} of {n}): ");
                    int integer = int.Parse(Console.ReadLine());

                    smallest = Math.Min(smallest, integer);
                    largest = Math.Max(largest, integer);
                }

                Console.WriteLine("\nThe smallest of the intgers is: {0}\nThe largest of the integers is: {1}", smallest, largest);
            }
        }
    }
}