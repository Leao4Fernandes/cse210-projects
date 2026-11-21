using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer = new Customer("John Doe", address);

        Order order = new Order(customer);

        Product product1 = new Product("Widget", "Apo8r51c", 2, 2);
        Product product2 = new Product("Gadget", "Jf2gds", 1, 2);
        order.AddProduct(product1);
        order.AddProduct(product2);

        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price (including shipping): ${order.GetTotalPrice():0.00}");
        Console.WriteLine();

        Address address2 = new Address("Rua das Flores 45", "Lisboa", "Lisboa", "Portugal");
        Customer customer2 = new Customer("Maria Santos", address2);

        Order order2 = new Order(customer2);

        Product product3 = new Product("Notebook", "Nb7x31", 3, 4);
        Product product4 = new Product("Pen", "Pn2q09", 1, 5);
        Product product5 = new Product("Backpack", "Bk5m80", 20, 1);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price (including shipping): ${order2.GetTotalPrice():0.00}");
    }
}