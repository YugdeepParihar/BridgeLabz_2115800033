using System;

class Level1 {
    static void Main() {
        int math = 94, physics = 95, chemistry = 96;
        double average = (math + physics + chemistry) / 3.0;

        Console.WriteLine($"Sam’s average mark in PCM is {average:F2}.");
    }
}
