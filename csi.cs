using System;
class Program
{
    static void Main(string[] args)
    {
        double principal = Convert.ToDouble(Console.ReadLine());
        double rate = Convert.ToDouble(Console.ReadLine());
        double time = Convert.ToDouble(Console.ReadLine());
        double simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine(simpleInterest);
    }
}
