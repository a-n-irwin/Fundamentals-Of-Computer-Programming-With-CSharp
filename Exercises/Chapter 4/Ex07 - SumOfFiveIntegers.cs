using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter4
    {
        public static class Ex07_SumOfFiveIntegers
        {
            // Contains main solution code 
            public static void Solution()
            {
                int counter = 0;
                int sum = 0;

                // The counter is increased depending on if an integer was successfully recorded or not
                while (counter < 5)
                {
                    // It's good to let the user know how much input they will be requested to make
                    Console.Write($"Enter any integer ({counter + 1} of 5): ");
                    bool isParsed = int.TryParse(Console.ReadLine(), out int integer);

                    if (isParsed)
                    {
                        sum += integer;
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid integer! Please provide a valid integer below");
                    }
                }

                Console.WriteLine($"The sum of these numbers is {sum}");
            }
        }
    }
}