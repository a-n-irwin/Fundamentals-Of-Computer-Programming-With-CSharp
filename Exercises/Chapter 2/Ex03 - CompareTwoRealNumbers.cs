using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter2
    {
        public static class Ex03_CompareTwoRealNumbers
        {
            // Contains main solution code 
            public static void Solution()
            {
                // How the program should be written is not specified, just the main goal of it. So I improvised.

                Console.Write("Enter two real numbers: ");

                string[] input = Console.ReadLine().Split();

                decimal a = decimal.Parse(input[0]);
                decimal b = decimal.Parse(input[1]);

                // This is what the exercise asks to be done: The below two lines
                // Required accuracy at least -> 0.000001
                decimal difference = Math.Abs(a - b);

                bool isEqual = difference <= 1E-6m;


                // Show the result of comparison
                Console.WriteLine("difference: {0:0.00000000000000000000}", difference);
                Console.WriteLine("Equal to precision of 0.000001: {0}", isEqual);
            }
        }
    }
}