using System;
using FundamentalsOfComputerProgrammingWithCSharp;
using System.Collections.Generic;
using System.IO;


public class Program
{
    public static void Main()
    {
        var outstream = Console.Out;
        var inpstream = Console.In;

        outstream.Write("Hello there, my name is Irwin. What is yours: ");

        var name = inpstream.ReadLine();

        outstream.Write($"Nice to meet you, {name}.");


        // So the console doesn't close afterwards
        Console.Read();
    }
}
