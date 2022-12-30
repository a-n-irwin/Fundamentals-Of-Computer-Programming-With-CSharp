Console.Write("Enter n, p, q, k: ");
string[] input = Console.ReadLine().Split();

uint n = uint.Parse(input[0]);

byte p = byte.Parse(input[1]);
byte q = byte.Parse(input[2]);
byte k = byte.Parse(input[3]);

for (int i = 0; i < k; ++i)
{
    // if the bits at positions p+i and q+i are not the same, then swap them
    if ( ((n >> p+i)&1) != ((n >> q+i)&1) )
    {
        // flip the bits at positions p+i and q+i
        n ^= (1u << p+i) ^ (1u << q+i);
    }
}

Console.WriteLine(n);
