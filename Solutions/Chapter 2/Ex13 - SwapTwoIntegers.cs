partial class Chapter2
{
    public static void Ex13_SwapTwoIntegers()
    {
        int a = 6;
        int b = -8;

        Console.WriteLine($"Before swap:\na: {a}\nb: {b}");

        // See also:
        // a = a + b;
        // b = a - b;
        // a = a - b;
        
        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine($"After swap:\na: {a}\nb: {b}");
    }
}