using System;

namespace ChapterThreeSolutions
{
    class Program
    {
	static void Main(string[] args)
	{
	    Console.Write("Enter earth weight: ");
	    float w = int.Parse(Console.ReadLine());
			
	    Console.WriteLine("Weight on moon: {0}", 0.17f*w);
	}
    }
}
