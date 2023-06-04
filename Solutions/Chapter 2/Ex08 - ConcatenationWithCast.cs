partial class Chapter2
{
    public static void Ex08_ConcatenationWithCast()
    {
        string a = "Hello";
        string b = "World";

        object c = a + " " + b;

        // Alternatively: Convert.toString(c) or c.ToString()
        string d = (string)c;

        Console.WriteLine(d);
    }
}