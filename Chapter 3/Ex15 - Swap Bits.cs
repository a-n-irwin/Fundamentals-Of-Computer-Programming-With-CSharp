Console.Write("Enter int: ");
uint n = uint.Parse(Console.ReadLine());

n = SwapBits(n, 24, 3);
n = SwapBits(n, 25, 4);
n = SwapBits(n, 26, 5);

uint SwapBits(uint n, int pos1, int pos2)
{
    // If the two bits are not the same, flip their values. Else, return the same integer
    return (((n >> pos1)&1) != ((n >> pos2)&1))?
        (uint)(n ^ (1 << pos1) ^ (1 << pos2)) : n;
}


Console.WriteLine(n);
