Console.Write("Enter min and max bounds(int): ");
string[] input = Console.ReadLine().Split();

int min = int.Parse(input[0]);
int max = int.Parse(input[1]);

max -= max%5;
if (min%5 != 0) min += 5 - (min%5);

Console.WriteLine($"{(max-min)/5 + 1} number(s) perfectly divisible by 5 in this range");
