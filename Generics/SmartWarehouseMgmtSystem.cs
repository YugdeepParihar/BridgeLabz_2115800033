using System;
using System.Collections.Generic;

// Abstract base class for all warehouse items
public abstract class WarehouseItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }

    public WarehouseItem(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }

    public abstract void DisplayItemDetails();
}

// Derived class for Electronics
public class Electronics : WarehouseItem
{
    public string Brand { get; set; }

    public Electronics(string name, int quantity, string brand) : base(name, quantity)
    {
        Brand = brand;
    }

    public override void DisplayItemDetails()
    {
        Console.WriteLine($"Electronics: {Name}, Brand: {Brand}, Quantity: {Quantity}");
    }
}

// Derived class for Groceries
public class Groceries : WarehouseItem
{
    public DateTime ExpiryDate { get; set; }

    public Groceries(string name, int quantity, DateTime expiryDate) : base(name, quantity)
    {
        ExpiryDate = expiryDate;
    }

    public override void DisplayItemDetails()
    {
        Console.WriteLine($"Groceries: {Name}, Expiry Date: {ExpiryDate.ToShortDateString()}, Quantity: {Quantity}");
    }
}

// Derived class for Furniture
public class Furniture : WarehouseItem
{
    public string Material { get; set; }

    public Furniture(string name, int quantity, string material) : base(name, quantity)
    {
        Material = material;
    }

    public override void DisplayItemDetails()
    {
        Console.WriteLine($"Furniture: {Name}, Material: {Material}, Quantity: {Quantity}");
    }
}

// Generic class to store items safely
public class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void DisplayAllItems()
    {
        foreach (var item in items)
        {
            item.DisplayItemDetails();
        }
    }
}

// Main program
public class Program
{
    public static void Main(string[] args)
    {
        // Create storage for Electronics
        Storage<Electronics> electronicsStorage = new Storage<Electronics>();
        electronicsStorage.AddItem(new Electronics("Smartphone", 50, "Samsung"));
        electronicsStorage.AddItem(new Electronics("Laptop", 30, "Dell"));

        // Create storage for Groceries
        Storage<Groceries> groceriesStorage = new Storage<Groceries>();
        groceriesStorage.AddItem(new Groceries("Apples", 100, DateTime.Now.AddDays(30)));
        groceriesStorage.AddItem(new Groceries("Milk", 200, DateTime.Now.AddDays(7)));

        // Create storage for Furniture
        Storage<Furniture> furnitureStorage = new Storage<Furniture>();
        furnitureStorage.AddItem(new Furniture("Chair", 150, "Wood"));
        furnitureStorage.AddItem(new Furniture("Table", 75, "Glass"));

        // Display all items
        Console.WriteLine("Electronics:");
        electronicsStorage.DisplayAllItems();

        Console.WriteLine("\nGroceries:");
        groceriesStorage.DisplayAllItems();

        Console.WriteLine("\nFurniture:");
        furnitureStorage.DisplayAllItems();
    }
}