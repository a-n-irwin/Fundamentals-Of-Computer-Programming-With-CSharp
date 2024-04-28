using System;
using System.Net.Http.Json;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter6
    {
        public static class Ex15_Alt_ConvertHexadecimalToDecimal
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter hexadecimal string: ");
                string hex = Console.ReadLine();

                int number = 0;


                for (int i = 0; i < hex.Length; ++i)
                {
                    char ch = Char.ToUpper(hex[i]);

                    // If a character is found outside this range of acceptable hex digits...
                    if (!((ch >= '0' && ch <= '9') || (ch >= 'A' && ch <= 'F')))
                    {
                        Console.WriteLine($"Error: Invalid hexadecimal digit {ch} found");
                        return;
                    }

                    // Using unicode char offset to convert the char digit to integer digit
                    number += (ch >= '0' && ch <= '9' ? ch - 48 : ch - 'A' + 10) * (int)Math.Pow(16, hex.Length - 1 - i);

                }

                // Alternatively
                // int number = Convert.ToInt32(hex, 16);
                Console.Write($"{hex} in decimal is: {number}");
            }
        }
    }
}