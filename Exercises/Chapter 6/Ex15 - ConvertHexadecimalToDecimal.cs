using System;
using System.Net.Http.Json;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter6
    {
        public static class Ex15_ConvertHexadecimalToDecimal
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter hexadecimal string: ");
                string hex = Console.ReadLine();

                int number = 0;


                for (int i = 0; i < hex.Length; ++i)
                {
                    // If a character is found outside this range of acceptable hex digits...
                    if (!Char.IsAsciiHexDigit(hex[i]))
                    {
                        Console.WriteLine($"Error: Invalid hexadecimal digit {hex[i]} found");
                        return;
                    }

                    // Using unicode char offset to convert the char digit to integer digit
                    number += (Char.IsNumber(hex[i]) ? hex[i] - 48 : hex[i] - 'A' + 10) * (int)Math.Pow(16, hex.Length - 1 - i);

                }

                // Alternatively
                // int number = Convert.ToInt32(hex, 16);
                Console.Write($"{hex} in decimal is: {number}");
            }
        }
    }
}