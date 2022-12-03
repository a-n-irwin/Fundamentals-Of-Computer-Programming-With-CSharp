Console.Write("Enter int: ");
int n = int.Parse(Console.ReadLine());

// 0 and 1 aren't prime. 0 can be divided by any number and 1 is ...well, 1
bool isPrime = (n == 0 || n == 1)? false : true;

for (int i = 2; i <= Math.Sqrt(n); ++i)
{
    if (n%i == 0)
    {
        isPrime = false;
        break;
    }
}

Console.WriteLine($"is {n} prime?: {isPrime}");
