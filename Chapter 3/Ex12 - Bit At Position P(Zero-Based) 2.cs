using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter int: ");
        int n = int.Parse(Console.ReadLine());
        
        Console.Write("Enter bit pos(zero-based): ");
        int p = int.Parse(Console.ReadLine());
        
        bool res = ((n >> p) & 1) == 1;
        Console.WriteLine($"bit at position {p} is 1: {res}");
    }
}
