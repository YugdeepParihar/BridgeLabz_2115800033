using System;

class Item
{
    public string Name;
    public int ID;
    public int Quantity;
    public double Price;
    public Item next;

    public Item(string name, int id, int quantity, double price)
    {
        Name = name;
        ID = id;
        Quantity = quantity;
        Price = price;
        next = null;
    }
}

class Inventory
{
    private Item head;

    // Add item at the beginning
    public void AddStart(string name, int id, int quantity, double price)
    {
        Item newItem = new Item(name, id, quantity, price);
        newItem.next = head;
        head = newItem;
    }

    // Add item at the end
    public void AddEnd(string name, int id, int quantity, double price)
    {
        Item newItem = new Item(name, id, quantity, price);
        if (head == null)
        {
            head = newItem;
            return;
        }
        Item temp = head;
        while (temp.next != null)
            temp = temp.next;
        temp.next = newItem;
    }

    // Add item at a specific position
    public void AddAtPosition(string name, int id, int quantity, double price, int position)
    {
        Item newItem = new Item(name, id, quantity, price);
        if (position < 1)
        {
            Console.WriteLine("Invalid Position");
            return;
        }
        if (position == 1)
        {
            newItem.next = head;
            head = newItem;
            return;
        }
        Item temp = head;
        for (int i = 1; temp != null && i < position - 1; i++)
            temp = temp.next;

        if (temp == null)
        {
            Console.WriteLine("Position out of range!");
            return;
        }
        newItem.next = temp.next;
        temp.next = newItem;
    }

    // Remove an item by ID
    public void RemoveItem(int id)
    {
        if (head == null)
        {
            Console.WriteLine("Inventory is empty!");
            return;
        }
        if (head.ID == id)
        {
            head = head.next;
            return;
        }
        Item temp = head;
        while (temp.next != null && temp.next.ID != id)
            temp = temp.next;

        if (temp.next == null)
        {
            Console.WriteLine("Item not found!");
            return;
        }
        temp.next = temp.next.next;
    }

    // Update item quantity by ID
    public void UpdateQuantity(int id, int newQuantity)
    {
        Item temp = head;
        while (temp != null)
        {
            if (temp.ID == id)
            {
                temp.Quantity = newQuantity;
                Console.WriteLine("Quantity updated successfully.");
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Item not found!");
    }

    // Search item by ID or Name
    public void SearchItem(int id)
    {
        Item temp = head;
        while (temp != null)
        {
            if (temp.ID == id)
            {
                Console.WriteLine($"Item Found: {temp.Name}, ID: {temp.ID}, Quantity: {temp.Quantity}, Price: {temp.Price}");
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Item not found!");
    }

    public void SearchItem(string name)
    {
        Item temp = head;
        while (temp != null)
        {
            if (temp.Name == name)
            {
                Console.WriteLine($"Item Found: {temp.Name}, ID: {temp.ID}, Quantity: {temp.Quantity}, Price: {temp.Price}");
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Item not found!");
    }

    // Calculate total inventory value
    public void TotalValue()
    {
        double totalValue = 0;
        Item temp = head;
        while (temp != null)
        {
            totalValue += temp.Price * temp.Quantity;
            temp = temp.next;
        }
        Console.WriteLine($"Total Inventory Value: {totalValue}");
    }

    // Display all items
    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("Inventory is empty!");
            return;
        }
        Item temp = head;
        Console.WriteLine("\nInventory List:");
        while (temp != null)
        {
            Console.WriteLine($"Item: {temp.Name}, ID: {temp.ID}, Quantity: {temp.Quantity}, Price: {temp.Price}");
            temp = temp.next;
        }
    }

    // Sort inventory by Item Name (Ascending)
    public void SortByName()
    {
        if (head == null || head.next == null) return;
        Item current, index;
        string tempName;
        int tempID, tempQuantity;
        double tempPrice;

        for (current = head; current != null; current = current.next)
        {
            for (index = current.next; index != null; index = index.next)
            {
                if (current.Name.CompareTo(index.Name) > 0)
                {
                    tempName = current.Name;
                    tempID = current.ID;
                    tempQuantity = current.Quantity;
                    tempPrice = current.Price;

                    current.Name = index.Name;
                    current.ID = index.ID;
                    current.Quantity = index.Quantity;
                    current.Price = index.Price;

                    index.Name = tempName;
                    index.ID = tempID;
                    index.Quantity = tempQuantity;
                    index.Price = tempPrice;
                }
            }
        }
        Console.WriteLine("Inventory sorted by Name.");
    }

    // Sort inventory by Price (Ascending)
    public void SortByPrice()
    {
        if (head == null || head.next == null) return;
        Item current, index;
        string tempName;
        int tempID, tempQuantity;
        double tempPrice;

        for (current = head; current != null; current = current.next)
        {
            for (index = current.next; index != null; index = index.next)
            {
                if (current.Price > index.Price)
                {
                    tempName = current.Name;
                    tempID = current.ID;
                    tempQuantity = current.Quantity;
                    tempPrice = current.Price;

                    current.Name = index.Name;
                    current.ID = index.ID;
                    current.Quantity = index.Quantity;
                    current.Price = index.Price;

                    index.Name = tempName;
                    index.ID = tempID;
                    index.Quantity = tempQuantity;
                    index.Price = tempPrice;
                }
            }
        }
        Console.WriteLine("Inventory sorted by Price.");
    }
}

class Program
{
    static void Main()
    {
        Inventory inventory = new Inventory();

        inventory.AddStart("Laptop", 101, 5, 750.0);
        inventory.AddEnd("Mouse", 102, 10, 25.0);
        inventory.AddAtPosition("Keyboard", 103, 8, 50.0, 2);

        inventory.Display();

        inventory.UpdateQuantity(102, 15);
        inventory.SearchItem(101);
        inventory.SearchItem("Mouse");

        inventory.TotalValue();
        inventory.SortByName();
        inventory.Display();

        inventory.SortByPrice();
        inventory.Display();

        inventory.RemoveItem(103);
        inventory.Display();
    }
}
