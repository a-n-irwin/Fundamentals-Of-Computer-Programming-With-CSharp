partial class Chapter2
{
    public static void Ex09_QuotedAndUnquotedStrings()
    {
        string quoted = "The \"use\" of quotations causes difficulties.";
        string unquoted = "The use of quotations causes difficulties.";

        // Not required
        Console.WriteLine("Quoted: {0}\nUnquoted: {1}", quoted, unquoted);
    }
}