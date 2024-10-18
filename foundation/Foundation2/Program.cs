using System;

public class Program
{
    public List<Product> productList = new List<Product>();
    static void Main(string[] args)
    {
        double totalCost = 0;

        //Enter addresses
        Address address1 = new Address("987 Cardboard Lane", "Monopoli", "BA", 70043, "Italia");
        Address address2 = new Address("902 W 4500 S", "Huntsville", "UT", 84317, "USA");

        //customers
        // Create customers
        Customer customer1 = new Customer("Rosa Fuentes", address1);
        Customer customer2 = new Customer("Angela Hubbard", address2);

        //Create a new Product objects and add them to the Order
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Hand Sanitizer", "A45677", 5.67, 3));  
        order1.AddProduct(new Product("Women's Flower Hat", "H8934", 14.95, 1));
        order1.AddProduct(new Product("Women's Boot Socks", "S3254", 11.97, 2));

        //Print Order Details
        Console.WriteLine(order1.PackingLabel());
        totalCost = order1.TotalCost();
        Console.WriteLine($"Total Cost: {totalCost:C}");
        Console.WriteLine("");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine("");

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Apple Slicer", "K98745", 10.98, 2));
        order2.AddProduct(new Product("Juice Press", "T23464", 65.23, 1));
        
         //Print Order Details
        Console.WriteLine(order2.PackingLabel());
        totalCost = order2.TotalCost();
        Console.WriteLine($"Total Cost: {totalCost:C}");
        Console.WriteLine("");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine("");


    }
}