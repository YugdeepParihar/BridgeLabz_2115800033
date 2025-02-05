using System;
using System.Collections.Generic;

// Employee class representing individual employees
class Employee
{
    public string Name { get; set; }
    public int EmployeeId { get; set; }

    // Constructor to initialize Employee details
    public Employee(string name, int employeeId)
    {
        Name = name;
        EmployeeId = employeeId;
    }

    // Method to display employee details
    public void DisplayEmployee()
    {
        Console.WriteLine($"Employee Name: {Name} | Employee ID: {EmployeeId}");
    }
}

// Department class representing a department in a company
class Department
{
    public string DepartmentName { get; set; }
    public List<Employee> Employees { get; set; }

    // Constructor to initialize department name and employee list
    public Department(string departmentName)
    {
        DepartmentName = departmentName;
        Employees = new List<Employee>(); // Creates the employee list for the department
    }

    // Method to add employee to the department
    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
        Console.WriteLine($"Employee {employee.Name} added to the {DepartmentName} department.");
    }

    // Method to display employees in the department
    public void DisplayEmployees()
    {
        Console.WriteLine($"Employees in {DepartmentName} Department:");
        foreach (var employee in Employees)
        {
            employee.DisplayEmployee();
        }
    }
}

// Company class representing a company with multiple departments
class Company
{
    public string CompanyName { get; set; }
    public List<Department> Departments { get; set; }

    // Constructor to initialize company name and department list
    public Company(string companyName)
    {
        CompanyName = companyName;
        Departments = new List<Department>(); // Creates the department list for the company
    }

    // Method to add a department to the company
    public void AddDepartment(Department department)
    {
        Departments.Add(department);
        Console.WriteLine($"Department {department.DepartmentName} added to the {CompanyName} company.");
    }

    // Method to display departments and employees in the company
    public void DisplayCompanyDetails()
    {
        Console.WriteLine($"Company: {CompanyName}");
        foreach (var department in Departments)
        {
            department.DisplayEmployees();
        }
    }
}

// Main program
class Program
{
    static void Main()
    {
        // Creating a Company
        Company company = new Company("Tech Solutions Ltd.");

        // Creating departments for the company
        Department hrDepartment = new Department("Human Resources");
        Department itDepartment = new Department("Information Technology");

        // Adding employees to the HR department
        hrDepartment.AddEmployee(new Employee("John Doe", 101));
        hrDepartment.AddEmployee(new Employee("Jane Smith", 102));

        // Adding employees to the IT department
        itDepartment.AddEmployee(new Employee("Alice Brown", 201));
        itDepartment.AddEmployee(new Employee("Bob White", 202));

        // Adding departments to the company
        company.AddDepartment(hrDepartment);
        company.AddDepartment(itDepartment);

        // Displaying the details of the company, departments, and employees
        company.DisplayCompanyDetails();

        // Now, the company and all its departments and employees will be deleted when the company object is destroyed.
        // In Composition, when the company object is destroyed, all departments and employees will be removed automatically.
    }
}