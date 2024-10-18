using System;


public class Order
{
    private Customer _customer;
    private List<Product> _products;
    private double ResShippingCost = 5;
    private double NonResShippingCost = 35;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
  
    //Get the shipping label
     public string ShippingLabel()
    {

        return "Shipping Label:\n" + _customer.CustomerInfo();
    }

    //Get the packing label
        public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += product.ProductLabel() + "\n";
        }
        return label;
    }
    public double TotalCost()
    {
        //initialize 
        double productCost = 0;
        double shipping  = 0;
        double totalCost = 0;

        foreach (var product in _products)
        {
            productCost += product.TotalProductCost();
        }
    
        if (_customer.LivesInUSA())
        {
            shipping = 5;
        }
        else 
        {
            shipping = 35;
        }
        totalCost = shipping + productCost;
        
        //print out ProductCost and shipping cost separately
        Console.WriteLine($"Final Product(s) Cost: {productCost:C}");
        Console.WriteLine($"Shipping Cost: {shipping:C}");

        return totalCost;  
    }

}