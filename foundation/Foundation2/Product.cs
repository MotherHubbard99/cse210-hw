using System;

public class Product
{
    private string _productName;
    private string _productID;
    private double _price;
    private int _quantity;
    //public double totalProductCost;

    public Product(string productName, string productID, double price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;

    }
    public double TotalProductCost()
    {
        //calculate total cost
        return _price * _quantity;
    }

     public string ProductLabel()
    {
        return $"{_productName} (ID: {_productID})";
    }


}