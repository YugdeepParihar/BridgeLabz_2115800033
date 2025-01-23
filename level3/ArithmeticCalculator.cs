using System;

// Class to perform basic arithmetic operations using a switch-case statement
class ArithmeticCalculator
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the first number
        Console.WriteLine("Enter first number:");
        double first = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the second number
        Console.WriteLine("Enter second number:");
        double second = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter an operator (+, -, *, /)
        Console.WriteLine("Enter an operator (+, -, *, /):");
        char op = Console.ReadLine()[0]; // Read the first character as the operator

        double result; // Variable to store the result of the operation

        // Switch-case to handle different arithmetic operations
        switch (op)
        {
            case '+': // Addition
                result = first + second;
                break;
            case '-': // Subtraction
                result = first - second;
                break;
            case '*': // Multiplication
                result = first * second;
                break;
            case '/': // Division
                if (second != 0) // Check for division by zero
                {
                    result = first / second;
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return;
                }
                break;
            default: // Invalid operator
                Console.WriteLine("Invalid operator.");
                return;
        }

        // Print the result of the operation
        Console.WriteLine("Result: " + result);
    }
}
