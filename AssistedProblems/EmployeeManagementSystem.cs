using System;

// Base class Employee
class Employee
{
    // Attributes
    public string Name { get; set; }
    public int Id { get; set; }
    public double Salary { get; set; }

    // Constructor
    public Employee(string name, int id, double salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    // Virtual method to display employee details (overridden in subclasses)
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Employee ID: {Id}, Name: {Name}, Salary: {Salary}");
    }
}

// Subclass Manager inheriting from Employee
class Manager : Employee
{
    public int TeamSize { get; set; }

    public Manager(string name, int id, double salary, int teamSize)
        : base(name, id, salary)
    {
        TeamSize = teamSize;
    }

    // Overriding DisplayDetails method
    public override void DisplayDetails()
    {
        Console.WriteLine($"Manager ID: {Id}, Name: {Name}, Salary: {Salary}, Team Size: {TeamSize}");
    }
}

// Subclass Developer inheriting from Employee
class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }

    public Developer(string name, int id, double salary, string programmingLanguage)
        : base(name, id, salary)
    {
        ProgrammingLanguage = programmingLanguage;
    }

    // Overriding DisplayDetails method
    public override void DisplayDetails()
    {
        Console.WriteLine($"Developer ID: {Id}, Name: {Name}, Salary: {Salary}, Programming Language: {ProgrammingLanguage}");
    }
}

// Subclass Intern inheriting from Employee
class Intern : Employee
{
    public string InternshipDuration { get; set; }

    public Intern(string name, int id, double salary, string internshipDuration)
        : base(name, id, salary)
    {
        InternshipDuration = internshipDuration;
    }

    // Overriding DisplayDetails method
    public override void DisplayDetails()
    {
        Console.WriteLine($"Intern ID: {Id}, Name: {Name}, Salary: {Salary}, Internship Duration: {InternshipDuration}");
    }
}

// Main class to test the Employee hierarchy
class Program
{
    static void Main()
    {
        // Creating instances of different employee types
        Employee manager = new Manager("Amit Sharma", 101, 90000, 10);
        Employee developer = new Developer("Ravi Kumar", 102, 75000, "C#");
        Employee intern = new Intern("Priya Singh", 103, 20000, "6 months");

        // Displaying details for each employee type
        manager.DisplayDetails();
        developer.DisplayDetails();
        intern.DisplayDetails();
    }
}