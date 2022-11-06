using System;

namespace ChapterThreeSolutions
{
    class DivisibleBy5n7
    {
	static void Main(string[] args)
	{
	    Console.Write("Enter int: ");
	    int n = int.Parse(Console.ReadLine());
	    
            // A number is divisible by a set of numbers if it is divisible by the lowest common multiple (LCM)	of the set of said numbers
	    int lcm5n7 = 35;
	    Console.WriteLine(n%lcm5n7 == 0? $"{n} is divisble by 5 and 7" : $"{n} is not divisible by 5 and 7");
	}
    }
}
