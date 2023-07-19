using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Address address2 = new Address("456 Park Ave", "Somewhere", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        List<Product> products1 = new List<Product>
        {
            new Product("Alaska Bottles", "JR345", 10, 2),
            new Product("Toyota Moreno", "M7TY6", 20, 1)
        };

        List<Product> products2 = new List<Product>
        {
            new Product("Socks of Legs", "UI890", 15, 3),
            new Product("Food for Thoughts", "GY567", 25, 2),
            new Product("Rice Bowls", "JUI88", 8, 5)
        };

        Order order1 = new Order(customer1, products1);
        Order order2 = new Order(customer2, products2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total cost for Order 1: ${order1.CalculateTotalCost()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total cost for Order 2: ${order2.CalculateTotalCost()}");
    }
}
