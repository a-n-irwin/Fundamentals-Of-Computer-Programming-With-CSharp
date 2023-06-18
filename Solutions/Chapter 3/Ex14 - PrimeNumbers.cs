partial class Chapter3
{
    public static void Ex14_PrimeNumbers()
    {
        Console.Write("Enter an integer in the range 1 - 100: ");
        int n = int.Parse(Console.ReadLine());

        // Input validation
        if (n > 100 || n < 1)
        {
            Console.WriteLine($"{n} is out of range");
            return;
        }

        bool isPrime = true;
        int length = Convert.ToInt32(Math.Sqrt(n));

        for (int i = 2; i <= length; ++i)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        Console.WriteLine($"{n} is prime? {isPrime}");
    }
}