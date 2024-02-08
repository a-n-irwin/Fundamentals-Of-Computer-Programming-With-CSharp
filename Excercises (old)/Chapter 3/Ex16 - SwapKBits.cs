partial class Chapter3
{
    public static void Ex16_SwapKBits()
    {
        Console.Write("Enter n, p, and q: ");
        string[] input = Console.ReadLine().Split();

        uint n = uint.Parse(input[0]);
        int p = int.Parse(input[1]);
        int q = int.Parse(input[2]);

        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i < k; ++i)
        {
            Console.WriteLine($"bit at position {p + i} (before swapping): {GetBit(n, p + i)}");
            Console.WriteLine($"bit at position {q + i} (before swapping): {GetBit(n, q + i)}");

            n = SwapBits(n, p + i, q + i);

            Console.WriteLine($"bit at position {p + i} (after swapping): {GetBit(n, p + i)}");
            Console.WriteLine($"bit at position {q + i} (after swapping): {GetBit(n, q + i)}\n");
        }

        Console.WriteLine($"value of n after swapping: {n}");
    }
}