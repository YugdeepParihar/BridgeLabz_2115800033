using System;

class Level1 {
    static void Main() {
        Console.WriteLine("Enter the number of students:");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());
        
        int maxHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;
        
        Console.WriteLine($"The maximum number of possible handshakes is {maxHandshakes}.");
    }
}
