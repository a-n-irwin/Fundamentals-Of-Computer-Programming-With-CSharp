Console.Write("Enter five(5) integers: ");
string[] input = Console.ReadLine().Split();

// Assume an initial maximum value
int max = int.Parse(input[0]);

for (int i = 1; i < input.Length; ++i)
{
    max = Math.Max(max, int.Parse(input[i]));
}

Console.WriteLine($"Maximum value: {max}");
