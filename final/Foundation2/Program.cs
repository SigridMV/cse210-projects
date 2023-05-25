using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        
        Product product1 = new Product("Product 1", "001", 30, 9);
        Product product2 = new Product("Product 2", "002", 3.65, 2);
        Product product3 = new Product("Product 3", "003", 10.57, 5);

        
        Address CustomerAddress1 = new Address("Principal Street 4154", "Santiago", "Región Metropolitana", "Chile");
        Customer customer1 = new Customer("Pablo Zúñiga", CustomerAddress1);

        
        Order orden = new Order(customer1);
        orden.AddProduct(product1);
        orden.AddProduct(product2);
        orden.AddProduct(product3);

        
        Console.WriteLine("Packing Label:");
        Console.WriteLine(orden.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(orden.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Final Prices for Billing: $" + orden.GetTotalPrice().ToString("F2"));

        Console.ReadLine();
    }
}