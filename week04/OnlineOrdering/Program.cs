using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P100", 800, 1));
        order1.AddProduct(new Product("Mouse", "P200", 20, 2));

        Address address2 = new Address("45 King Rd", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Mary Johnson", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P300", 500, 1));
        order2.AddProduct(new Product("Headphones", "P400", 75, 1));
        order2.AddProduct(new Product("Charger", "P500", 25, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");
        Console.WriteLine("\n----------------------\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}