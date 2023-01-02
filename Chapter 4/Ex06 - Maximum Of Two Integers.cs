Console.Write("Enter two ints: ");
string[] input = Console.ReadLine().Split();

int a = int.Parse(input[0]);
int b = int.Parse(input[1]);

Console.WriteLine($"The max of {a} and {b} is {Math.Max(a,b)}");
