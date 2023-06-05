partial class Chapter3
{
    public static void Ex03_ThirdDigit()
    {
        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());

        bool thirdDigitIsSeven = (n%1000)/100 == 7;

        Console.WriteLine($"Third digit is 7? {thirdDigitIsSeven}");
    }
}