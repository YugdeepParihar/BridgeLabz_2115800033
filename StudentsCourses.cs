using System;
using System.Collections.Generic;

// Course Class
class Course
{
    public string CourseName { get; set; }
    public int CourseId { get; set; }
    public List<Student> EnrolledStudents { get; set; }

    // Constructor to initialize course details
    public Course(int courseId, string courseName)
    {
        CourseId = courseId;
        CourseName = courseName;
        EnrolledStudents = new List<Student>();
    }

    // Method to enroll student in the course
    public void EnrollStudent(Student student)
    {
        EnrolledStudents.Add(student);
        student.EnrollInCourse(this);  // Enroll student in the course from the student side
        Console.WriteLine($"{student.Name} has been enrolled in {CourseName}.");
    }

    // Method to display students enrolled in the course
    public void DisplayEnrolledStudents()
    {
        Console.WriteLine($"Students enrolled in {CourseName}:");
        foreach (var student in EnrolledStudents)
        {
            Console.WriteLine($"- {student.Name}");
        }
    }
}

// Student Class
class Student
{
    public string Name { get; set; }
    public int StudentId { get; set; }
    public List<Course> Courses { get; set; }

    // Constructor to initialize student details
    public Student(int studentId, string name)
    {
        StudentId = studentId;
        Name = name;
        Courses = new List<Course>();
    }

    // Method to enroll in a course
    public void EnrollInCourse(Course course)
    {
        Courses.Add(course);
    }

    // Method to view enrolled courses
    public void ViewEnrolledCourses()
    {
        Console.WriteLine($"{Name} is enrolled in the following courses:");
        foreach (var course in Courses)
        {
            Console.WriteLine($"- {course.CourseName}");
        }
    }
}

// School Class (Aggregation with Students)
class School
{
    public string SchoolName { get; set; }
    public List<Student> Students { get; set; }

    // Constructor to initialize school details
    public School(string schoolName)
    {
        SchoolName = schoolName;
        Students = new List<Student>();
    }

    // Method to add student to the school
    public void AddStudent(Student student)
    {
        Students.Add(student);
        Console.WriteLine($"{student.Name} has been added to {SchoolName}.");
    }

    // Method to display all students in the school
    public void DisplayAllStudents()
    {
        Console.WriteLine($"Students in {SchoolName}:");
        foreach (var student in Students)
        {
            Console.WriteLine($"- {student.Name}");
        }
    }
}

// Main Program
class Program
{
    static void Main()
    {
        // Create a School object
        School school = new School("Greenwood High School");

        // Create some Student objects
        Student student1 = new Student(1, "Alice");
        Student student2 = new Student(2, "Bob");

        // Add students to the school
        school.AddStudent(student1);
        school.AddStudent(student2);

        // Create Course objects
        Course course1 = new Course(101, "Mathematics");
        Course course2 = new Course(102, "Science");

        // Enroll students in courses
        course1.EnrollStudent(student1);
        course1.EnrollStudent(student2);

        course2.EnrollStudent(student1);

        // Display the courses that a student is enrolled in
        student1.ViewEnrolledCourses();
        student2.ViewEnrolledCourses();

        // Display the students enrolled in a course
        course1.DisplayEnrolledStudents();
        course2.DisplayEnrolledStudents();

        // Display all students in the school
        school.DisplayAllStudents();
    }
}