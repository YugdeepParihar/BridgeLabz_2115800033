using System;

class HandshakeCalculator
{
    static void Main(string[] args)
    {
        // Take user input for the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Check if the number of students is valid
        if (numberOfStudents <= 0)
        {
            Console.WriteLine("Number of students must be greater than 0.");
            return;
        }

        // Calculate the maximum number of handshakes
        int maxHandshakes = CalculateHandshakes(numberOfStudents);

        // Display the result
        Console.WriteLine($"The maximum number of handshakes among {numberOfStudents} students is {maxHandshakes}.");
    }

    // Method to calculate the maximum number of handshakes using the combination formula
    static int CalculateHandshakes(int n)
    {
        return (n * (n - 1)) / 2;
    }
}