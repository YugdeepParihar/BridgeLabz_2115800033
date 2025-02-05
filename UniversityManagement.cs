using System;
using System.Collections.Generic;

// Course Class
class Course
{
    public string CourseName { get; set; }
    public List<Student> EnrolledStudents { get; set; }
    public Professor CourseProfessor { get; set; }

    public Course(string courseName)
    {
        CourseName = courseName;
        EnrolledStudents = new List<Student>();
    }

    // Method to assign a professor to the course
    public void AssignProfessor(Professor professor)
    {
        CourseProfessor = professor;
        Console.WriteLine($"{professor.ProfessorName} has been assigned to teach {CourseName}");
    }

    // Method to enroll students into the course
    public void EnrollStudent(Student student)
    {
        EnrolledStudents.Add(student);
        Console.WriteLine($"{student.StudentName} has been enrolled in {CourseName}");
    }

    // Method to display course details
    public void DisplayCourseDetails()
    {
        Console.WriteLine($"Course Name: {CourseName}");
        Console.WriteLine($"Professor: {CourseProfessor?.ProfessorName}");
        Console.WriteLine("Enrolled Students:");
        foreach (var student in EnrolledStudents)
        {
            Console.WriteLine($"- {student.StudentName}");
        }
        Console.WriteLine();
    }
}

// Student Class
class Student
{
    public string StudentName { get; set; }
    public int StudentId { get; set; }

    public Student(int studentId, string studentName)
    {
        StudentId = studentId;
        StudentName = studentName;
    }

    // Method for student to enroll in a course
    public void EnrollCourse(Course course)
    {
        course.EnrollStudent(this);
    }

    // Display student details
    public void DisplayStudentDetails()
    {
        Console.WriteLine($"Student Name: {StudentName}, Student ID: {StudentId}");
    }
}

// Professor Class
class Professor
{
    public string ProfessorName { get; set; }
    public int ProfessorId { get; set; }

    public Professor(int professorId, string professorName)
    {
        ProfessorId = professorId;
        ProfessorName = professorName;
    }

    // Method to assign a professor to a course
    public void AssignCourse(Course course)
    {
        course.AssignProfessor(this);
    }

    // Display professor details
    public void DisplayProfessorDetails()
    {
        Console.WriteLine($"Professor Name: {ProfessorName}, Professor ID: {ProfessorId}");
    }
}

class Program
{
    static void Main()
    {
        // Creating Professors
        Professor professor1 = new Professor(1, "Dr. Smith");
        Professor professor2 = new Professor(2, "Dr. Johnson");

        // Creating Courses
        Course course1 = new Course("Computer Science 101");
        Course course2 = new Course("Mathematics 101");

        // Assign Professors to Courses
        professor1.AssignCourse(course1);
        professor2.AssignCourse(course2);

        // Creating Students
        Student student1 = new Student(101, "Ram");
        Student student2 = new Student(102, "Suresh");

        // Students enroll in courses
        student1.EnrollCourse(course1);
        student2.EnrollCourse(course1);
        student2.EnrollCourse(course2);

        // Display course details
        course1.DisplayCourseDetails();
        course2.DisplayCourseDetails();

        // Display student details
        student1.DisplayStudentDetails();
        student2.DisplayStudentDetails();

        // Display professor details
        professor1.DisplayProfessorDetails();
        professor2.DisplayProfessorDetails();
    }
}