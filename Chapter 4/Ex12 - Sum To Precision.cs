// This exercise wasn't clear at all. I had to look at the solutions
// and guidelines in order to understand the problem
double oldSum = 0;
double sum = 1.0;

for (int i = 2; Math.Abs(sum - oldSum) > 0.001; ++i)
{
    oldSum = sum;
    sum += (i%2 == 0)? 1.0/i : -1.0/i;
}

Console.WriteLine($"Sum: {sum:F3}");
