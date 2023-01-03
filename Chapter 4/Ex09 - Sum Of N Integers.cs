int sum = 0;

Console.Write("Enter number of inputs: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Enter integers: ");

for (int i = 0; i < n; ++i)
{
    Console.Write($"int({i+1}): ");
    sum += int.Parse(Console.ReadLine());
}

Console.WriteLine($"Sum: {sum}");
