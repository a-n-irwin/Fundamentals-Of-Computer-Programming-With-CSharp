using System;
using System.Net;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter5
    {
        // I am not sure if I completly understood what this exercise was asking to do
        public static class Ex08_ChoiceOfInput
        {
            public static void Solution()
            {
                Console.WriteLine("What kind of input do you want to enter?");
                Console.WriteLine("1. Integer\n2. Real number\n3. String\n");

                // By default, assumed to be the option for an integer
                int response = 1;
                bool condition = true;

                // While the exercise did not ask for input validation, I decided to do one here, as the program would be awkward without it
                while (condition)
                {
                    Console.Write("Response: ");
                    bool isNotParsed = !int.TryParse(Console.ReadLine(), out response);
                    // The condition for continuing this input validation loop
                    condition = isNotParsed || (response != 1 && response != 2 && response != 3);

                    if (condition)
                    {
                        Console.WriteLine("Please enter a valid response\n");
                    }
                }

                Console.WriteLine("\nYou selected option {0}", response);
                Console.Write("Enter input: ");

                // Handling the response
                switch (response)
                {
                    case 1:
                        Console.WriteLine("Result: {0}", int.TryParse(Console.ReadLine(), out int @int) ? @int + 1 : "Invalid integer");
                        break;
                    case 2:
                        Console.WriteLine("Result: {0}", double.TryParse(Console.ReadLine(), out double @double) ? @double + 1 : "Invalid real number");
                        break;
                    case 3:
                        Console.WriteLine("Result: {0}", Console.ReadLine() + '*');
                        break;
                }
            }
        }
    }
}