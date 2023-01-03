// Not recommended for use! This is just to show that
// the printing statements may be reduced by buffering, but
// the way the code does it is a bit reckless and is only okay for small n inputs
using System.Text;

Console.Write("Enter n: ");
int n = System.Math.Abs(int.Parse(Console.ReadLine()));

StringBuilder sb = new (n*n);

for (int i = 1; i <= n; ++i)
    sb.Append(i + "\n");

Console.WriteLine(sb);
