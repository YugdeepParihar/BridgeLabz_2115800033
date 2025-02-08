using System;

// Superclass Animal
class Animal
{
    // Attributes
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Virtual method for sound (will be overridden in subclasses)
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }

    // Method to display animal details
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

// Subclass Dog inheriting from Animal
class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) { }

    // Overriding MakeSound method
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

// Subclass Cat inheriting from Animal
class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }

    // Overriding MakeSound method
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

// Subclass Bird inheriting from Animal
class Bird : Animal
{
    public Bird(string name, int age) : base(name, age) { }

    // Overriding MakeSound method
    public override void MakeSound()
    {
        Console.WriteLine("Bird chirps");
    }
}

// Main class to test the hierarchy
class Program
{
    static void Main()
    {
        // Creating instances of each animal subclass
        Animal dog = new Dog("Bruno", 5);
        Animal cat = new Cat("Whiskers", 3);
        Animal bird = new Bird("Tweety", 2);

        // Displaying details and calling MakeSound method
        dog.DisplayInfo();
        dog.MakeSound();

        cat.DisplayInfo();
        cat.MakeSound();

        bird.DisplayInfo();
        bird.MakeSound();
    }
}