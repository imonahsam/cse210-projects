using System;

class Program
{
    static void Main(string[] args)
    {
        Address addressUSA = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", addressUSA);
        Product product1 = new Product("Widget", "W1", 10.0, 2);
        Product product2 = new Product("Gadget", "G1", 5.0, 3);
        Order order1 = new Order(customer1, new List<Product> {product1, product2});

        Address addressInternational = new Address("456 Oak St", "Othercity", "ProvinceX", "Canada");
        Customer customer2 = new Customer("David Whitmer", addressInternational);
        Product product3 = new Product("Furniture", "F1", 8.0, 4);
        Product product4 = new Product("Accessories", "A1", 7.0, 3);
        Order order2 = new Order(customer2, new List<Product> {product3, product4});

        Console.WriteLine("Order 1 - Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("\nOrder 1 - Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("\nOrder 1 - Total Price:");
        Console.WriteLine(order1.CalculateTotalCost());

        Console.WriteLine("\nOrder 2 - Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("\nOrder 2 - Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine("\nOrder 2 - Total Price:");
        Console.WriteLine(order2.CalculateTotalCost());
    }
}