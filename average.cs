using System;
class Program
{
    static void Main(string[] args)
    {
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());
        double num3 = Convert.ToDouble(Console.ReadLine());
        double average = (num1 + num2 + num3) / 3;
        Console.WriteLine(average);
    }
}
