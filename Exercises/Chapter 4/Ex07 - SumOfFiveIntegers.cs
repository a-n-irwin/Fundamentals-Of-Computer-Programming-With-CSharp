using System;



namespace FundamentalsOfComputerProgrammingWithCSharp;



partial class Chapter4
{
    // Note: This exercise explicitly requested for input validation
    public static void Ex07_SumOfFiveIntegers()
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