using System;
class Program
{
    static void Main(string[] args)
    {
        double baseNum = Convert.ToDouble(Console.ReadLine());
        double exponent = Convert.ToDouble(Console.ReadLine());
        double result = Math.Pow(baseNum, exponent);
        Console.WriteLine(result);
    }
}
