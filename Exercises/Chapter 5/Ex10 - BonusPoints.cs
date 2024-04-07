using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter5
    {
        public static class Ex10_BonusPoints
        {
            public static void Solution()
            {
                int score = 0;

                Console.Write("Enter score (1 - 9): ");
                score = int.Parse(Console.ReadLine());

                // Apply the bonus points to the score, based on the criteria
                if (score >= 7 && score <= 9)
                {
                    score *= 1000;
                }
                else if (score >= 4 && score <= 6)
                {
                    score *= 100;
                }
                else if (score >= 1 && score <= 3)
                {
                    score *= 10;
                }
                else
                {
                    Console.WriteLine("ERROR: You have entered an invalid score");
                    return;
                }

                Console.WriteLine("Total score: {0}", score);
            }
        }
    }
}