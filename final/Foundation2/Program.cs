using System;

class Program
{
    static void Main(string[] args)
    {
        // Create first customer and order
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LAP123", 1200.99m, 1));
        order1.AddProduct(new Product("Mouse", "MSE456", 25.50m, 2));

        // Create second customer and order
        Address address2 = new Address("55 King Rd", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Smith", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "PHN789", 799.99m, 1));
        order2.AddProduct(new Product("Headphones", "HDP999", 59.99m, 3));

        // Display Order 1 Details
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}\n");

        // Display Order 2 Details
        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}");
    }
}
