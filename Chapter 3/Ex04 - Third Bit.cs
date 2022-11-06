using System;

namespace ChapterThreeSolutions
{
    class Program
    {
	static void Main(string[] args)
	{
	    Console.Write("Enter int: ");
	    int n = int.Parse(Console.ReadLine());
			
	    // Right-shift the third bit two positions (i.e make it the first bit), then perform an '&' operation
	    int bit = (n >> 2) & 1;
	    Console.WriteLine($"Third bit of {n} is {bit}");
	}
    }
}
