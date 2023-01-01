CompanyInfo company = new CompanyInfo();

company.GetInfo();
company.DisplayInfo();


// Store details about a company
class CompanyInfo
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }
    public string Website { get; set; }


    public ManagerInfo Manager { get; set; }
    
    
    public CompanyInfo() { Manager = new ManagerInfo(); }


    public void GetInfo()
    {
        Console.WriteLine("---------- Enter Company Details Below ----------\n");
        Console.Write("Company name:     ");
        Name = Console.ReadLine();

        Console.Write("Company Address:  ");
        Address = Console.ReadLine();

        Console.Write("Company Phone:    ");
        Phone = Console.ReadLine();

        Console.Write("Company Fax:      ");
        Fax = Console.ReadLine();

        Console.Write("Company Website:  ");
        Website = Console.ReadLine();


        // Manager's details
        Console.Write("\n > Enter Manager's Details Below <\n\n");

        Console.Write("First Name: ");
        Manager.FirstName = Console.ReadLine();

        Console.Write("Last Name:  ");
        Manager.LastName = Console.ReadLine();

        Console.Write("Phone:      ");
        Manager.Phone = Console.ReadLine();
    }

    public void DisplayInfo()
    {
        Console.WriteLine("\n-----------------------------------------------\n");
        Console.WriteLine(" ------Company Information------\n");
        Console.WriteLine($"Company name:     {Name}");
        Console.WriteLine($"Company Address:  {Address}");
        Console.WriteLine($"Company Phone:    {Phone}");
        Console.WriteLine($"Company Fax:      {Fax}");
        Console.WriteLine($"Company Website:  {Website}\n");
        Console.WriteLine($" > Manager's Details <\n");
        Console.WriteLine($"First Name: {Manager.FirstName}");
        Console.WriteLine($"Last Name:  {Manager.LastName}");
        Console.WriteLine($"Phone:      {Manager.Phone}");
    }
}

// Store details about a manager
class ManagerInfo
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
}
