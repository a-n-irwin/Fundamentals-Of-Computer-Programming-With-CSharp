using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter2
    {
        public static class Ex08_ConcatenationWithCast
        {
            // Contains main solution code 
            public static void Solution()
            {
                string a = "Hello";
                string b = "World";

                object c = a + " " + b;

                // Alternatively: Convert.toString(c) or c.ToString()
                string d = (string)c;

                Console.WriteLine(d);
            }
        }
    }
}