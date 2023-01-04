ulong a = 0;
ulong b = 1;

Console.WriteLine("First 100 numbers in the Fibonacci sequence: ");
Console.Write($"{a}, {b}");

for (int i = 2; i < 100; ++i)
{
    b = a + b;
    a = b - a; // assign the previous value of b into a
    
    Console.Write($", {b}");
}
