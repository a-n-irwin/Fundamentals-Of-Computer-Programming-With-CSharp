using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter2
    {
        public static class Ex09_QuotedAndUnquotedStrings
        {
            // Contains main solution code 
            public static void Solution()
            {
                string quoted = @"The ""use"" of quotations causes difficulties.";
                string unquoted = "The \"use\" of quotations causes difficulties.";

                // Not required
                Console.WriteLine("Quoted: {0}\nUnquoted: {1}", quoted, unquoted);
            }
        }
    }
}