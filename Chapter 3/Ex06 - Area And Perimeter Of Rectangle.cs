using System;

namespace ChapterThreeSolutions
{
    class Program
    {
	static void Main(string[] args)
	{
	    Console.Write("Enter width and height: ");
	    string[] input = Console.ReadLine().Split();
			
	    float w = float.Parse(input[0]);
	    float h = float.Parse(input[1]);
			
	    Console.WriteLine("Area of rectangle: {0}", w*h);
	    Console.WriteLine("Perimeter of rectangle: {0}", 2*(w+h));
	}
    }
}
