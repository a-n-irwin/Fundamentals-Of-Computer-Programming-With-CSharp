using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter6
    {
        public static class Ex14_ConvertDecimalToHexadecimal
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter an integer: ");
                int number = int.Parse(Console.ReadLine());

                string hex = number == 0 ? "0" : string.Empty;

                // Using an array to map the indicies 0 - 5 to hex alphabet digits
                char[] specialDigits = { 'A', 'B', 'C', 'D', 'E', 'F' };

                Console.Write($"{number} in hexadecimal system is: ");

                while (number > 0)
                {
                    int rem = number % 16;

                    // Conditionally prepend the remainder because of the special digits which we can't represent as decimal digits
                    hex = (rem >= 10 ? specialDigits[rem - 10].ToString() : rem) + hex;

                    number /= 16;
                }

                // Alternatively
                // hex = Convert.ToString(number, 16);

                Console.WriteLine($"{hex}");
            }
        }
    }
}