using System;

namespace Fundamentals_Of_Computer_Programming_With_CSharp;

partial class Chapter2
{
    public static void Ex07_Concatenation()
    {
        string a = "Hello";
        string b = "World";

        object c = a + " " + b;

        Console.WriteLine(c);
    }
}