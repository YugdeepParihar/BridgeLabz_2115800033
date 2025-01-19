using System;
class Program
{
    static void Main(string[] args)
    {
        double length = Convert.ToDouble(Console.ReadLine());
        double width = Convert.ToDouble(Console.ReadLine());
        double perimeter = 2 * (length + width);
        Console.WriteLine(perimeter);
    }
}
