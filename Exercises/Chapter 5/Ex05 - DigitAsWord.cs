using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter5
    {
        public static class Ex05_DigitAsWord
        {
            public static void Solution()
            {
                Console.Write("Enter a digit (0 - 9): ");
                int digit = int.Parse(Console.ReadLine());

                string word;

                switch (digit)
                {
                    case 0:
                        word = "Zero";
                        break;
                    case 1:
                        word = "One";
                        break;
                    case 2:
                        word = "Two";
                        break;
                    case 3:
                        word = "Three";
                        break;
                    case 4:
                        word = "Four";
                        break;
                    case 5:
                        word = "Five";
                        break;
                    case 6:
                        word = "Six";
                        break;
                    case 7:
                        word = "Seven";
                        break;
                    case 8:
                        word = "Eight";
                        break;
                    case 9:
                        word = "Nine";
                        break;
                    default:
                        word = String.Empty;
                        break;
                }

                Console.Write("Digit as word: {0}", word != String.Empty ? word : "No word representation found (digit out of range)");
            }
        }
    }
}