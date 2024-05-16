using System;
using System.Collections.Generic;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter5
    {
        // Note: This solution uses some things not taught yet in the book. And also that I am not very experienced in writing 
        // efficient code. I Just wanted to try to adapt the excercise for a constrained N input
        public static class Ex09_Subsets_Alt
        {
            public static void Solution()
            {
                int size = 0;
                bool condition = true;

                // Input validation is necessary here as we don't want an N value to large
                while (condition)
                {
                    Console.WriteLine("Enter set size (1 - 10): ");
                    // We want to stop the loop when the input was succesfully parsed to an int and it is within the range specified
                    condition = !(int.TryParse(Console.ReadLine(), out size) && size >= 1 && size <= 10);
                }


                var set = new List<int>(size);
                var subsets = new LinkedList<List<int>>();


                Console.WriteLine($"Enter {size} integers below: ");

                // Get the inputs
                for (int index = 0; index < set.Count; ++index)
                {
                    Console.Write($"integer {index + 1} of {size}: ");
                    set[index] = int.Parse(Console.ReadLine());
                }

                // Find the subsets whose elements sum up to zero (0):

            }
        }
    }
}