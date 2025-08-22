using System;

class Supermarket
{
    public string Name { get; set; }
    public string Location { get; set; }

    public Supermarket(string name, string location)
    {
        Name = name;
        Location = location;
    }
}

class Product
{
    public string Name { get; set; }
    public float Price { get; set; }
    public int Stock { get; set; }

    public Product(string name, float price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }

    public void ShowStock()
    {
        Console.WriteLine($"Stock for {Name}: {Stock} units");
    }

    public virtual void Sell()
    {
        Console.WriteLine($"Selling product: {Name} | Price: {Price}");
    }

    public void ReduceStock(int quantity)
    {
        if (quantity <= Stock)
            Stock -= quantity;
        else
            Console.WriteLine("Not enough stock available");
    }
}

class Beverage : Product
{
    public Beverage(string name, float price, int stock) : base(name, price, stock) { }
}

class Food : Product
{
    public Food(string name, float price, int stock) : base(name, price, stock) { }
}


class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public int DNI { get; set; }
    public float Salary { get; set; }

    public Employee(string firstName, string lastName, string phone, string email, int dni, float salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Phone = phone;
        Email = email;
        DNI = dni;
        Salary = salary;
    }
}

class ITDepartment : Employee
{
    public string Area { get; set; }
    public bool Degree { get; set; }
    public bool HasComputer { get; set; }
    public int PeopleInCharge { get; set; }

    public ITDepartment(string firstName, string lastName, string phone, string email, int dni, float salary, string area, bool degree, bool hasComputer, int people)
        : base(firstName, lastName, phone, email, dni, salary)
    {
        Area = area;
        Degree = degree;
        HasComputer = hasComputer;
        PeopleInCharge = people;
    }
}

class Programmer : Employee
{
    public string Language { get; set; }
    public string Level { get; set; }
    public int TimesCrashedProduction { get; set; }
    public ITDepartment Department { get; set; }

    public Programmer(string language, string level, int times, string firstName, string lastName, string phone, string email, int dni, float salary, ITDepartment dept)
        : base(firstName, lastName, phone, email, dni, salary)
    {
        Language = language;
        Level = level;
        TimesCrashedProduction = times;
        Department = dept;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Programmer: {FirstName} {LastName} | Phone: {Phone} | Email: {Email} | DNI: {DNI}");
        Console.WriteLine($"Language: {Language} | Level: {Level} | Area: {Department.Area} | Degree: {Department.Degree} | Computer: {Department.HasComputer} | People in charge: {Department.PeopleInCharge}");
    }
}

class Environment
{
    public string OS { get; set; }
    public int RAM { get; set; }
    public string Database { get; set; }
    public string App { get; set; }

    public Environment(string os, int ram, string db, string app)
    {
        OS = os;
        RAM = ram;
        Database = db;
        App = app;
    }

    public void CheckDeployment()
    {
        if (OS.ToLower() == "linux" && RAM >= 4 && Database.ToLower() == "postgresql" && App.ToLower() == "openjdk")
            Console.WriteLine("Deployment successful!");
        else
            Console.WriteLine("Cannot deploy environment");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // --- Supermarket ---
        Console.Write("Enter supermarket name: ");
        string marketName = Console.ReadLine();
        Console.Write("Enter supermarket location: ");
        string marketLocation = Console.ReadLine();
        Supermarket market = new Supermarket(marketName, marketLocation);

        // --- Food ---
        Console.Write("Enter food name: ");
        string foodName = Console.ReadLine();
        Console.Write("Enter food price: ");
        float foodPrice = float.Parse(Console.ReadLine());
        Console.Write("Enter food stock: ");
        int foodStock = int.Parse(Console.ReadLine());
        Food bread = new Food(foodName, foodPrice, foodStock);
        bread.ShowStock();
        bread.Sell();
        Console.Write("Enter quantity to sell: ");
        int qty = int.Parse(Console.ReadLine());
        bread.ReduceStock(qty);
        bread.ShowStock();

        // --- Beverage ---
        Console.Write("Enter beverage name: ");
        string bevName = Console.ReadLine();
        Console.Write("Enter beverage price: ");
        float bevPrice = float.Parse(Console.ReadLine());
        Console.Write("Enter beverage stock: ");
        int bevStock = int.Parse(Console.ReadLine());
        Beverage juice = new Beverage(bevName, bevPrice, bevStock);
        juice.ShowStock();
        juice.Sell();
        Console.Write("Enter quantity to sell: ");
        qty = int.Parse(Console.ReadLine());
        juice.ReduceStock(qty);
        juice.ShowStock();

        // --- IT Department & Programmer ---
        ITDepartment dept = new ITDepartment("Alice", "Smith", "12345", "alice@email.com", 123456, 2500, "IT", true, true, 5);
        Programmer prog = new Programmer("C#", "Senior", 0, "Bob", "Johnson", "67890", "bob@email.com", 654321, 3000, dept);
        prog.ShowInfo();

        // --- Environment ---
        Environment env = new Environment("Linux", 4, "PostgreSQL", "OpenJDK");
        env.CheckDeployment();
    }
}
