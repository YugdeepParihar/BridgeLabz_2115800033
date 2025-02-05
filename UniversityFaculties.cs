using System;
using System.Collections.Generic;

// Faculty Class (Aggregation: A faculty member can exist independently of the department)
class Faculty
{
    public string FacultyName { get; set; }
    public int FacultyId { get; set; }

    public Faculty(int facultyId, string facultyName)
    {
        FacultyId = facultyId;
        FacultyName = facultyName;
    }

    // Method to assign faculty to a department
    public void AssignToDepartment(Department department)
    {
        department.AddFaculty(this);
    }
}

// Department Class (Part of University with Composition: Deleting a University deletes its departments)
class Department
{
    public string DepartmentName { get; set; }
    public int DepartmentId { get; set; }
    public List<Faculty> FacultyMembers { get; set; }

    public Department(int departmentId, string departmentName)
    {
        DepartmentId = departmentId;
        DepartmentName = departmentName;
        FacultyMembers = new List<Faculty>();
    }

    // Method to add a faculty member to the department
    public void AddFaculty(Faculty faculty)
    {
        FacultyMembers.Add(faculty);
    }

    // Method to display all faculty members in the department
    public void DisplayFaculty()
    {
        Console.WriteLine($"Faculty members in {DepartmentName} department:");
        foreach (var faculty in FacultyMembers)
        {
            Console.WriteLine($"- {faculty.FacultyName}");
        }
    }
}

// University Class (Composition: Deleting a University deletes its departments)
class University
{
    public string UniversityName { get; set; }
    public int UniversityId { get; set; }
    public List<Department> Departments { get; set; }

    public University(int universityId, string universityName)
    {
        UniversityId = universityId;
        UniversityName = universityName;
        Departments = new List<Department>();
    }

    // Method to add a department to the university
    public void AddDepartment(Department department)
    {
        Departments.Add(department);
    }

    // Method to display all departments in the university
    public void DisplayDepartments()
    {
        Console.WriteLine($"Departments in {UniversityName}:");
        foreach (var department in Departments)
        {
            Console.WriteLine($"- {department.DepartmentName}");
            department.DisplayFaculty(); // Display faculty in each department
        }
    }
}

class Program
{
    static void Main()
    {
        // Create University object
        University university = new University(101, "XYZ University");

        // Create Departments
        Department dept1 = new Department(1, "Computer Science");
        Department dept2 = new Department(2, "Mechanical Engineering");

        // Add departments to university
        university.AddDepartment(dept1);
        university.AddDepartment(dept2);

        // Create Faculty members
        Faculty faculty1 = new Faculty(1, "Dr. Suresh");
        Faculty faculty2 = new Faculty(2, "Dr. Ramesh");
        Faculty faculty3 = new Faculty(3, "Dr. Mohan");

        // Assign faculty members to departments
        faculty1.AssignToDepartment(dept1);
        faculty2.AssignToDepartment(dept1);
        faculty3.AssignToDepartment(dept2);

        // Display university departments and faculty members
        university.DisplayDepartments();

        // Show that Faculty members can exist independently
        Console.WriteLine("\nFaculty members can exist independently:");
        Console.WriteLine($"Faculty: {faculty1.FacultyName}, Department: {dept1.DepartmentName}");
        Console.WriteLine($"Faculty: {faculty2.FacultyName}, Department: {dept1.DepartmentName}");
        Console.WriteLine($"Faculty: {faculty3.FacultyName}, Department: {dept2.DepartmentName}");

        // Demonstrate the Composition relationship:
        // Deleting the university would also delete all its departments and faculty members
        Console.WriteLine("\nUniversity and its departments are deleted...");
        university = null; // This deletes the university and all associated departments
    }
}