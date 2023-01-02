int sum = 0;

Console.WriteLine("Enter five(5) integers: ");

// Loop counter is controlled within the loop code
for (int i = 0; i < 5; )
{
    Console.Write($"int({i+1}): ");
    try
    {
        sum += int.Parse(Console.ReadLine());
        // The loop counter will only increase when a valid input is entered
        i++;
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid integer input! Please Retry.");
    }
}

Console.WriteLine($"Sum: {sum}");
