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
			
	    bool isWithinCircle = (distanceFromOrigin < 5);
	    bool isOutsideRect = x < -1 || x > 5 || y < 1 || y > 5;
			
            Console.WriteLine($"\nPoint distance from origin: {distanceFromOrigin}");
	    Console.WriteLine($"Within Circle: {isWithinCircle}\nOutside Rect: {isOutsideRect}\nWithin circle and outside rect: {isWithinCircle && isOutsideRect}");
        }
    }
}
