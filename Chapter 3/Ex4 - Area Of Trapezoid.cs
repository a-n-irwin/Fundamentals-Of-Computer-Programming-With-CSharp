using System;

namespace ChapterThreeSolutions
{
    class Program
    {
	static void Main(string[] args)
	{
	    Console.Write("Enter a, b and h: ");
	    string[] input = Console.ReadLine().Split();
			
	    float a = float.Parse(input[0]);
	    float b = float.Parse(input[1]);
            float h = float.Parse(input[2]);
			
	    float area = 0.5f*(a+b)*h;
			
	    Console.WriteLine("Area of trapezoid: {0}", area);
	}
    }
}
