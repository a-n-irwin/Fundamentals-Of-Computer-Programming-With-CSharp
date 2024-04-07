using System;
using System.Globalization;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter5
    {
        public static class Ex11_NumberToWords
        {
            // Contains main solution code 
            public static void Solution()
            {
                int number = 0;
                bool condition = true;

                // Persistent input prompt
                while (condition)
                {
                    Console.Write("Enter an integer (0 - 999): ");
                    if (condition = !(int.TryParse(Console.ReadLine(), out number) && number >= 0 && number <= 999))
                    {
                        Console.WriteLine("Please enter a valid integer within the range specified");
                    }
                }

                // Convert the number to words
                Console.WriteLine(number < 100 ? TensAndUnitsToWords(number) : String.Format("{0} Hundred {1}", SpecialNumberToWord(number / 100), TensAndUnitsToWords(number % 100)));
            }

            // Converts Tens and Units to Words
            static string TensAndUnitsToWords(int number)
            {
                if (number >= 0 && number <= 20)
                    return SpecialNumberToWord(number);
                else if (number >= 21 && number <= 99)
                    return String.Format("{0} {1}", SpecialNumberToWord(number / 10 * 10), number % 10 > 0 ? SpecialNumberToWord(number % 10) : "");

                return String.Empty;
            }

            // Sort of Like a look-up object which maps special numbers to their equivalent in words. These special numbers are the
            // key numbers we neeed to solve this exercise
            static string SpecialNumberToWord(int number)
            {
                switch (number)
                {
                    case 0:
                        return "Zero";
                    case 1:
                        return "One";
                    case 2:
                        return "Two";
                    case 3:
                        return "Three";
                    case 4:
                        return "Four";
                    case 5:
                        return "Five";
                    case 6:
                        return "Six";
                    case 7:
                        return "Seven";
                    case 8:
                        return "Eight";
                    case 9:
                        return "Nine";
                    case 10:
                        return "Ten";
                    case 11:
                        return "Eleven";
                    case 12:
                        return "Twelve";
                    case 13:
                        return "Thirteen";
                    case 14:
                        return "Fourteen";
                    case 15:
                        return "Fifteen";
                    case 16:
                        return "Sixteen";
                    case 17:
                        return "Seventeen";
                    case 18:
                        return "Eighteen";
                    case 19:
                        return "Nineteen";
                    case 20:
                        return "Twenty";
                    case 30:
                        return "Thirty";
                    case 40:
                        return "Forty";
                    case 50:
                        return "Fifty";
                    case 60:
                        return "Sixty";
                    case 70:
                        return "Seventy";
                    case 80:
                        return "Eighty";
                    case 90:
                        return "Ninety";
                    default:
                        return String.Empty;
                }
            }
        }
    }


}