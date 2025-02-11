using System;

class Student {
    public int RollNo;
    public string Name;
    public int Age;
    public string Grade;
    public Student next;

    public Student(int rollNo, string name, int age, string grade) {
        RollNo = rollNo;
        Name = name;
        Age = age;
        Grade = grade;
        next = null;
    }
}

class StudentFunctions {
    private Student head;

    // Add student at the beginning
    public void AddStart(int rollNo, string name, int age, string grade) {
        Student newStudent = new Student(rollNo, name, age, grade);
        newStudent.next = head;
        head = newStudent;
    }

    // Add student at the end
    public void AddLast(int rollNo, string name, int age, string grade) {
        Student newStudent = new Student(rollNo, name, age, grade);
        if (head == null) {
            head = newStudent;
            return;
        }
        Student temp = head;
        while (temp.next != null) {
            temp = temp.next;
        }
        temp.next = newStudent;
    }

    // Add student at a specific position
    public void AddPosition(int rollNo, string name, int age, string grade, int position) {
        Student newStudent = new Student(rollNo, name, age, grade);
        if (position < 1) {
            Console.WriteLine("Invalid position!");
            return;
        }

        if (position == 1) {  // Insert at head
            newStudent.next = head;
            head = newStudent;
            return;
        }

        Student temp = head;
        for (int i = 1; temp != null && i < position - 1; i++) {
            temp = temp.next;
        }

        if (temp == null) {
            Console.WriteLine("Position out of range!");
            return;
        }

        newStudent.next = temp.next;
        temp.next = newStudent;
    }

    // Delete student by Roll Number
    public void DeleteByRollNo(int rollNo) {
        if (head == null) {
            Console.WriteLine("No records found!");
            return;
        }

        if (head.RollNo == rollNo) {
            head = head.next;
            Console.WriteLine($"Student with Roll No {rollNo} deleted.");
            return;
        }

        Student temp = head;
        while (temp.next != null && temp.next.RollNo != rollNo) {
            temp = temp.next;
        }

        if (temp.next == null) {
            Console.WriteLine("Student not found!");
        } else {
            temp.next = temp.next.next;
            Console.WriteLine($"Student with Roll No {rollNo} deleted.");
        }
    }

    // Search for student by Roll Number
    public void SearchByRollNo(int rollNo) {
        Student temp = head;
        while (temp != null) {
            if (temp.RollNo == rollNo) {
                Console.WriteLine($"Found - Roll No: {temp.RollNo}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Student not found!");
    }

    // Update student's grade by Roll Number
    public void UpdateGrade(int rollNo, string newGrade) {
        Student temp = head;
        while (temp != null) {
            if (temp.RollNo == rollNo) {
                temp.Grade = newGrade;
                Console.WriteLine($"Updated - Roll No: {temp.RollNo}, New Grade: {temp.Grade}");
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Student not found!");
    }

    // Display all student records
    public void Display() {
        Student temp = head;
        if (temp == null) {
            Console.WriteLine("No student records available.");
            return;
        }
        while (temp != null) {
            Console.WriteLine($"Roll No: {temp.RollNo}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
            temp = temp.next;
        }
    }
}

class SinglyLinkedList {
    static void Main() {
        StudentFunctions s = new StudentFunctions();

        // Adding student records
        s.AddStart(2, "ritik", 21, "A");
        s.AddStart(1, "amit", 22, "B");
        s.AddLast(3, "soni", 23, "C");
        s.AddPosition(10, "Sohan", 19, "A+", 2);

       
        Console.WriteLine("\nStudent Records:");
        s.Display();

        // Searching for a student
        Console.WriteLine("\nSearching for Roll No 3:");
        s.SearchByRollNo(3);

        // Updating grade
        Console.WriteLine("\nUpdating grade for Roll No 2:");
        s.UpdateGrade(2, "A+");

        // Display all records after update
        Console.WriteLine("\nUpdated Student Records:");
        s.Display();

        // Deleting a student
        Console.WriteLine("\nDeleting Roll No 10:");
        s.DeleteByRollNo(10);

        // Display all records after deletion
        Console.WriteLine("\nFinal Student Records:");
        s.Display();
    }
}
