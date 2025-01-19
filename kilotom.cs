using System;
class Program
{
    static void Main(string[] args)
    {
        double kilometers = Convert.ToDouble(Console.ReadLine());
        double miles = kilometers * 0.621371;
        Console.WriteLine(miles);
    }
}
