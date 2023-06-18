partial class Chapter3
{
    public static void Ex11_BitAtPosition()
    {
        Console.Write("Enter the integer and bit position: ");
        string[] input = Console.ReadLine().Split();

        int n = int.Parse(input[0]);
        int p = int.Parse(input[1]);

        // Get the bit at position p. I assume "p" is a zero based index position
        int bit = (n >> p) & 1;
        Console.WriteLine($"bit at position {p} is {bit}");
    }
}