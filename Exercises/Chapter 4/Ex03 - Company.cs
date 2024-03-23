using System;


namespace FundamentalsOfComputerProgrammingWithCSharp;



partial class Chapter4
{
    public static void Ex03_Comapany()
    {

        Console.WriteLine("\n\t---------> Enter Company Details Below <---------");

        Console.Write("Name: ");
        string companyName = Console.ReadLine();

        Console.Write("Address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Phone number: ");
        string companyPhoneNumber = Console.ReadLine();

        Console.Write("Fax number: ");
        string companyFaxNumber = Console.ReadLine();

        Console.Write("Website: ");
        string companyWebsite = Console.ReadLine();

        Console.WriteLine("\n\t---------> Enter Manager's Details Below <---------");


        Console.Write("Manager's first name: ");
        string companyManagerFirstName = Console.ReadLine();

        Console.Write("Manager's last name: ");
        string companyManagerLastName = Console.ReadLine();

        Console.Write("Manager's phone number: ");
        string companyManagerPhoneNumber = Console.ReadLine();


        Console.WriteLine("\n\n\t---------> Company Details Below <---------");
        Console.WriteLine($"\tName: {companyName}");
        Console.WriteLine($"\tAddress: {companyAddress}");
        Console.WriteLine($"\tPhone number: {companyPhoneNumber}");
        Console.WriteLine($"\tFax number: {companyFaxNumber}");
        Console.WriteLine($"\tWebsite: {companyWebsite}");

        Console.WriteLine("\n\t---------> Manager's Details Below <---------");


        Console.WriteLine($"\tManager's first name: {companyManagerFirstName}");
        Console.WriteLine($"\tManager's last name: {companyManagerLastName}");
        Console.WriteLine($"\tManager's phone number: {companyManagerPhoneNumber}");
    }
}