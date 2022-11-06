using System;

namespace ChapterThreeSolutions
{
    class Program
    {
	static void Main(string[] args)
	{
	    Console.Write("Enter int: ");
	    int n = int.Parse(Console.ReadLine());
			
	    // If when we divide the number by 1000 the remainder is in the range 700 - 799
	    // it means the third digit of the number (if it has one) is 7
	    bool res = (n%1000 >= 700) && (n%1000 <= 799);
	    Console.WriteLine(res? $"third digit of {n} is 7" : $"third digit of {n} is NOT 7");
	}
    }
}
