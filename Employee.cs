using System;

class Employee
{
    private static string CompanyName = "Tech Solutions"; // Static variable shared by all employees
    private static int totalEmployees = 0; // Counter for the total number of employees

    public readonly int Id;  // Readonly variable for employee ID (cannot be changed after assignment)
    public string Name;
    public string Designation;

    // Constructor using 'this' to initialize Name, Id, and Designation
    public Employee(string name, string designation)
    {
        this.Id = new Random().Next(1000, 9999); // Generate a unique ID for each employee
        this.Name = name;
        this.Designation = designation;
        totalEmployees++; // Increment total employees count
    }

    // Static method to display the total number of employees
    public static void DisplayTotalEmployees()
    {
        Console.WriteLine($"Total Employees in {CompanyName}: {totalEmployees}");
    }

    // Method to display employee details using the 'is' operator for type checking
    public void DisplayEmployeeDetails()
    {
        if (this is Employee)  // Check if the object is an instance of Employee
        {
            Console.WriteLine("\n--- Employee Details ---");
            Console.WriteLine($"Employee ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Designation: {Designation}");
        }
        else
        {
            Console.WriteLine("Invalid employee record!");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of employees: ");
        int employeeCount = Convert.ToInt32(Console.ReadLine());

        Employee[] employees = new Employee[employeeCount];

        // Creating employees
        for (int i = 0; i < employeeCount; i++)
        {
            Console.WriteLine($"\nEnter details for Employee {i + 1}:");

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Designation: ");
            string designation = Console.ReadLine();

            employees[i] = new Employee(name, designation); // Initialize employee object
        }

        // Display total employees in the company
        Employee.DisplayTotalEmployees();

        // Display details of all employees
        Console.WriteLine("\nEmployee Details:");
        foreach (Employee employee in employees)
        {
            employee.DisplayEmployeeDetails(); // Display details for each employee
        }
    }
}
