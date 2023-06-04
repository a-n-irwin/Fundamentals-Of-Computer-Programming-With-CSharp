partial class Chapter1
{
    public static void Ex11_AgeAfterTenYears()
    {
        Console.Write("What's your age?: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Your age in 10 years: {0}", age + 10);
    }
}