using System;

namespace ChapterThreeSolutions
{
    class Program
    {
        static void Main(string[] args)
	{
            int[] results = new int[4];
	    string input = "";
			
	    // Question strictly requires the operation to be done on a four digit integer, hence this check
	    while (input.Length != 4)
	    {
	        Console.Write("Enter a four digit integer: ");
	        input = Console.ReadLine();
	    }
			
	    int n = int.Parse(input);
			
	    // Third operation: last digit to the front
	    results[2] = n%10 * (int)Math.Pow(10, 3) + n/10;
			
	    // Fourth operation: swap second and third digits
	    results[3] = n/1000 * (int)Math.Pow(10, 3) + ((n/10)%10)*(int)Math.Pow(10, 2) + ((n/100)%10)*10 + n%10;
			
	    // First and second operation: sum of digits, and reversed digits
	    for (int i = 0; i < 4; ++i)
	    {
	        results[0] += n%10;
		results[1] += (n%10) * (int)Math.Pow(10,3-i);
	        n /= 10;
	    }
			
	    Console.WriteLine($"\nsum of digits: {results[0]}\ndigits reversed: {results[1]}");
	    Console.WriteLine($"last digit to front: {results[2]}\nswap second and third digits: {results[3]}");
	}
    }
}
