partial class Chapter2
{
    public static void Ex03_CompareTwoRealNumbers()
    {
        double a = 45;
        double b = 45.0000010;

        bool isEqual = Math.Abs(a - b) <= 1e-5;
        Console.WriteLine("The numbers are " + (isEqual? "equal" : "not equal"));
    }
}