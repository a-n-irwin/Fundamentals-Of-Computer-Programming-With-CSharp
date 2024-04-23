using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter6
    {
        public static class Ex12_ConvertDecimalToBinary
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter an integer: ");
                int number = int.Parse(Console.ReadLine());

                // A default value depending on if the input is zero or not
                string binary = number == 0 ? "0" : string.Empty;

                Console.Write($"{number} in binary system is: ");

                while (number > 0)
                {
                    binary = (number % 2) + binary;
                    number /= 2;
                }

                // Alternatively
                // binary = Convert.ToString(number, 2);

                Console.WriteLine($"{binary}");
            }
        }
    }
}