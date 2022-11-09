using System;

namespace ChapterThreeSolutions
{
    class Program
    {
	static void Main(string[] args)
	{
	    Console.Write("Enter x and y: ");
	    string[] input = Console.ReadLine().Split();
			
	    float x = float.Parse(input[0]);
	    float y = float.Parse(input[1]);
			
	    float distanceFromOrigin = MathF.Sqrt(x*x + y*y);
			
	    Console.WriteLine($"\nRadius: 5 units\nPoint ({x}, {y}) is {distanceFromOrigin} units away from the circle's origin");
	    Console.WriteLine(distanceFromOrigin < 5.0f? "Point is within circle" : "Point is NOT within circle");
	}
    }
}
