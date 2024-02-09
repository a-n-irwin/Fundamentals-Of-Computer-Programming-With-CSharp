partial class Chapter3
{
    public static void Ex02_DivisibleByFiveAndSeven()
    {
        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());

        int lcm5n7 = 5*7;

        bool isDivisible = n % lcm5n7 == 0;
        
        Console.WriteLine($"{n} is divisible by 5 and 7? {isDivisible}");
    }
}