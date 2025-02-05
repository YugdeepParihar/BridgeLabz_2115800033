using System;
using System.Collections.Generic;

// Product Class
class Product
{
    public string ProductName { get; set; }
    public double Price { get; set; }
    
    public Product(string productName, double price)
    {
        ProductName = productName;
        Price = price;
    }
}

// Order Class
class Order
{
    public int OrderId { get; set; }
    public List<Product> Products { get; set; }
    public double TotalAmount { get; set; }

    public Order(int orderId)
    {
        OrderId = orderId;
        Products = new List<Product>();
        TotalAmount = 0;
    }

    // Method to add product to the order and calculate total amount
    public void AddProduct(Product product)
    {
        Products.Add(product);
        TotalAmount += product.Price;
    }

    // Display order details
    public void DisplayOrderDetails()
    {
        Console.WriteLine($"Order ID: {OrderId}");
        Console.WriteLine("Products in the Order:");
        foreach (var product in Products)
        {
            Console.WriteLine($"- {product.ProductName}: {product.Price}");
        }
        Console.WriteLine($"Total Amount: {TotalAmount}\n");
    }
}

// Customer Class
class Customer
{
    public string CustomerName { get; set; }
    public int CustomerId { get; set; }
    public List<Order> Orders { get; set; }

    public Customer(int customerId, string customerName)
    {
        CustomerId = customerId;
        CustomerName = customerName;
        Orders = new List<Order>();
    }

    // Method for customer to place an order
    public void PlaceOrder(Order order)
    {
        Orders.Add(order);
        Console.WriteLine($"Order placed successfully! Order ID: {order.OrderId}");
    }

    // Display customer details and all their orders
    public void DisplayCustomerDetails()
    {
        Console.WriteLine($"Customer: {CustomerName} (ID: {CustomerId})");
        Console.WriteLine("Orders placed by the customer:");
        foreach (var order in Orders)
        {
            order.DisplayOrderDetails();
        }
    }
}

class Program
{
    static void Main()
    {
        // Create Products
        Product product1 = new Product("Laptop", 50000);
        Product product2 = new Product("Smartphone", 20000);
        Product product3 = new Product("Headphones", 3000);
        Product product4 = new Product("Mouse", 1000);

        // Create a Customer
        Customer customer = new Customer(1, "Suresh");

        // Create Orders and add products to them
        Order order1 = new Order(101);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(102);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Customer places orders
        customer.PlaceOrder(order1);
        customer.PlaceOrder(order2);

        // Display customer details and all orders placed
        customer.DisplayCustomerDetails();
    }
}