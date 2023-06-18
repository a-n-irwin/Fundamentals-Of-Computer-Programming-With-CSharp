partial class Chapter3
{
    public static void Ex09_PointWithinCircleOutsideRect()
    {
        Console.Write("Enter x and y: ");
        string[] input = Console.ReadLine().Split();

        double x = double.Parse(input[0]);
        double y = double.Parse(input[1]);

        double radius = 5;

        // Circle is centered around origin {0, 0}, so we don't need to calculate any offsets
        // Use Pythagoras' theorem to calculate the distance of the given point from the origin
        double distance = Math.Sqrt(x*x + y*y);
        bool isWithinCircle = distance < radius;

        // Rectangle is positioned at {-1. 1} and {5, 5} (bottom left and top right positions, respectively)
        bool isOutsideRectangle = (x < -1 || x > 5 || y < 1 || y > 5);
        // bool isOutsideRectangle = !(x >= -1 && x <= 5 && y >= 1 && y <= 5);

        Console.WriteLine($"\nradius: {radius}\npoint: ({x}, {y})\ndistance from origin (0, 0): {distance:0.000}\n");
        Console.WriteLine($"is within circle? {isWithinCircle}\nis outside rectangle? {isOutsideRectangle}");
        Console.WriteLine($"is within circle and outside rectangle? {isWithinCircle & isOutsideRectangle}");
    }
}