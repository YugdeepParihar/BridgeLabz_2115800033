using System;

class Level1 {
    static void Main() {
        double kilometers = 10.8;
        double miles = kilometers / 1.6;

        Console.WriteLine($"The distance {kilometers} km in miles is {miles:F2}.");
    }
}
