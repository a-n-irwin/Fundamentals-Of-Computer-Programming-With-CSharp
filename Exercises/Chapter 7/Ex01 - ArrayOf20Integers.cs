using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter07
    {
        public static class Ex01_ArrayOf20Integers
        {
            // Contains main solution code 
            public static void Solution()
            {
                int[] array = new int[20];

                for (int i = 0; i < array.Length; ++i)
                    array[i] = i * 5;

                foreach (int item in array) Console.Write($"{item} ");
            }
        }
    }
}