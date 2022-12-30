Console.Write("Enter n, p, v: ");
string[] input = Console.ReadLine().Split();

uint n = uint.Parse(input[0]);
int p = int.Parse(input[1]);
int v = int.Parse(input[2]);

// Any non-zero value entered as v will be taken as 1
if (v != 0) v = 1;

uint bit = (n >> p) & 1;
int mask = 1 << p;

Console.WriteLine(bit != v? n ^ mask : n);
