partial class Chapter3
{
    public static void Ex12_BitAtPosition()
    {
        Console.Write("Enter the integer and bit position: ");
        string[] input = Console.ReadLine().Split();

        int v = int.Parse(input[0]);
        int p = int.Parse(input[1]);

        // Get the bit at position p. I assume "p" is a zero based index position
        bool bit = ((v >> p) & 1) == 1;
        Console.WriteLine($"bit at position {p} is 1? {bit}");
    }
}