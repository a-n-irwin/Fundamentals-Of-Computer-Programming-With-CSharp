using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter5
    {
        public static class Ex09_Subsets
        {
            public static void Solution()
            {
                int[] set = new int[5];

                Console.WriteLine("Enter 5 integers below: ");

                // Get the inputs
                for (int index = 0; index < set.Length; ++index)
                {
                    Console.Write($"integer {index + 1} of 5: ");
                    set[index] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("\nSubsets whose sum of elements is 0: ");

                // Find all subsets in which the sum of the elements is 0
                // Sets of one element
                if (set[0] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}", set[0]) + '}');
                }
                if (set[1] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}", set[1]) + '}');
                }
                if (set[2] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}", set[2]) + '}');
                }
                if (set[3] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}", set[3]) + '}');
                }
                if (set[4] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}", set[4]) + '}');
                }
                // Sets of two elements
                if (set[0] + set[1] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}, {1}", set[0], set[1]) + '}');
                }
                if (set[0] + set[2] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}, {1}", set[0], set[2]) + '}');
                }
                if (set[0] + set[3] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}, {1}", set[0], set[3]) + '}');
                }
                if (set[0] + set[4] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}, {1}", set[0], set[4]) + '}');
                }
                if (set[1] + set[2] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}, {1}", set[1], set[2]) + '}');
                }
                if (set[1] + set[3] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}, {1}", set[1], set[3]) + '}');
                }
                if (set[1] + set[4] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}, {1}", set[1], set[4]) + '}');
                }
                if (set[2] + set[3] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}, {1}", set[2], set[3]) + '}');
                }
                if (set[2] + set[4] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}, {1}", set[2], set[4]) + '}');
                }
                if (set[3] + set[4] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}, {1}", set[3], set[4]) + '}');
                }
                // Sets of three elements
                if (set[0] + set[1] + set[2] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}, {1}, {2}", set[0], set[1], set[2]) + '}');
                }
                if (set[0] + set[1] + set[3] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}, {1}, {2}", set[0], set[1], set[3]) + '}');
                }
                if (set[0] + set[1] + set[4] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}, {1}, {2}", set[0], set[1], set[4]) + '}');
                }
                if (set[0] + set[2] + set[3] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}, {1}, {2}", set[0], set[2], set[3]) + '}');
                }
                if (set[0] + set[2] + set[4] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}, {1}, {2}", set[0], set[2], set[4]) + '}');
                }
                if (set[0] + set[3] + set[4] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}, {1}, {2}", set[0], set[3], set[4]) + '}');
                }
                if (set[1] + set[2] + set[3] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}, {1}, {2}", set[1], set[2], set[3]) + '}');
                }
                if (set[1] + set[2] + set[4] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}, {1}, {2}", set[1], set[2], set[4]) + '}');
                }
                if (set[1] + set[3] + set[4] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}, {1}, {2}", set[1], set[3], set[4]) + '}');
                }
                if (set[2] + set[3] + set[4] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}, {1}, {2}", set[2], set[3], set[4]) + '}');
                }
                // Sets of four elements
                if (set[0] + set[1] + set[2] + set[3] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}, {1}, {2}, {3}", set[0], set[1], set[2], set[3]) + '}');
                }
                if (set[0] + set[1] + set[2] + set[4] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}, {1}, {2}, {3}", set[0], set[1], set[2], set[4]) + '}');
                }
                if (set[0] + set[1] + set[3] + set[4] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}, {1}, {2}, {3}", set[0], set[1], set[3], set[4]) + '}');
                }
                if (set[0] + set[2] + set[3] + set[4] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}, {1}, {2}, {3}", set[0], set[2], set[3], set[4]) + '}');
                }
                if (set[1] + set[2] + set[3] + set[4] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}, {1}, {2}, {3}", set[1], set[2], set[3], set[4]) + '}');
                }
                // Sets of five
                if (set[0] + set[1] + set[2] + set[3] + set[4] == 0)
                {
                    Console.WriteLine('{' + String.Format("{0}, {1}, {2}, {3}, {4}", set[0], set[1], set[2], set[3], set[4]) + '}');
                }
            }
        }
    }
}