using System;

// Base class Vehicle
class Vehicle
{
    public int MaxSpeed { get; set; }
    public string FuelType { get; set; }

    // Constructor
    public Vehicle(int maxSpeed, string fuelType)
    {
        MaxSpeed = maxSpeed;
        FuelType = fuelType;
    }

    // Virtual method to display vehicle information
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Max Speed: {MaxSpeed} km/h, Fuel Type: {FuelType}");
    }
}

// Subclass Car inheriting from Vehicle
class Car : Vehicle
{
    public int SeatCapacity { get; set; }

    public Car(int maxSpeed, string fuelType, int seatCapacity)
        : base(maxSpeed, fuelType)
    {
        SeatCapacity = seatCapacity;
    }

    // Overriding DisplayInfo method
    public override void DisplayInfo()
    {
        Console.WriteLine($"Car - Max Speed: {MaxSpeed} km/h, Fuel Type: {FuelType}, Seat Capacity: {SeatCapacity}");
    }
}

// Subclass Truck inheriting from Vehicle
class Truck : Vehicle
{
    public int PayloadCapacity { get; set; }

    public Truck(int maxSpeed, string fuelType, int payloadCapacity)
        : base(maxSpeed, fuelType)
    {
        PayloadCapacity = payloadCapacity;
    }

    // Overriding DisplayInfo method
    public override void DisplayInfo()
    {
        Console.WriteLine($"Truck - Max Speed: {MaxSpeed} km/h, Fuel Type: {FuelType}, Payload Capacity: {PayloadCapacity} kg");
    }
}

// Subclass Motorcycle inheriting from Vehicle
class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar)
        : base(maxSpeed, fuelType)
    {
        HasSidecar = hasSidecar;
    }

    // Overriding DisplayInfo method
    public override void DisplayInfo()
    {
        Console.WriteLine($"Motorcycle - Max Speed: {MaxSpeed} km/h, Fuel Type: {FuelType}, Has Sidecar: {HasSidecar}");
    }
}

// Main class to demonstrate polymorphism
class Program
{
    static void Main()
    {
        // Creating instances of different vehicle types
        Vehicle[] vehicles = new Vehicle[]
        {
            new Car(180, "Petrol", 5),
            new Truck(120, "Diesel", 5000),
            new Motorcycle(150, "Petrol", false)
        };

        // Displaying vehicle information using polymorphism
        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.DisplayInfo();
        }
    }
}