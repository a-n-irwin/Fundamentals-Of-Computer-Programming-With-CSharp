partial class Chapter3
{
    public static void Ex13_ChangeBitAtPosition()
    {
        Console.Write("Enter n and p: ");
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int p = int.Parse(input[1]);

        Console.Write("Enter bit(0 or 1): ");
        int v = int.Parse(Console.ReadLine());

        // Validating input v 
        if (v != 0 && v != 1)
        {
            Console.WriteLine("the target bit must be a value of 0 or 1");
            return;
        }

        int bit = (n >> p) & 1;
        Console.WriteLine($"old bit at position {p}: {bit}");
        
        // Solution to the excersie
        if (bit != v) n ^= 1 << p;
        bit = (n >> p) & 1;

        Console.WriteLine($"new bit at position {p}: {bit}");
        Console.WriteLine($"new value of n: {n}");
    }
}