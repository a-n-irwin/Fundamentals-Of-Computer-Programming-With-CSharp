Console.Write("Enter radius: ");
double r = double.Parse(Console.ReadLine());

Console.WriteLine("Perimeter: {0:F4}", System.Math.PI*2*r);
Console.WriteLine("Area: {0:F4}", System.Math.PI*r*r);
