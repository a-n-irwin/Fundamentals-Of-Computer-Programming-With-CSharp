using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter6
    {
        public static class Ex04_DeckOfCards
        {
            // Contains main solution code 
            public static void Solution()
            {
                // The book already introuduced the concept of arrays before this point...
                char[] suits = { 'D', 'H', 'C', 'S' };
                char[] court = { 'A', 'K', 'Q', 'J' };

                Console.WriteLine("Deck of Cards: ");

                foreach (char suit in suits)
                {
                    // Print the normal cards
                    for (int i = 2; i <= 10; ++i)
                    {
                        Console.WriteLine($"{suit}-{i}");
                    }

                    // Print the court
                    foreach (char card in court)
                    {
                        Console.WriteLine($"{suit}-{card}");
                    }
                }
            }
        }
    }
}