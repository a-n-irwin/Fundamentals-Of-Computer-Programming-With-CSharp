partial class Chapter1
{
    public static void Ex10_Sequence()
    {
        for (int i = 0; i < 100; ++i)
        {
            int n = i + 2;
            // Can be done alternantively with an if-else statement
            Console.Write((n%2 == 0? n : -n) + " ");
        }
    }
}