namespace Fundamentals_Of_Computer_Programming_With_CSharp;

partial class Chapter1
{
    public static void Ex10_Sequence()
    {
        for (int i = 0; i < 100; ++i)
        {
            int n = i + 2;

            System.Console.Write(n % 2 == 0 ? n : -n);
            System.Console.Write(i < 99 ? ", " : ".");
        }
    }
}