using System;

class Product
{
    private string _productName;
    private string _productId;
    private int _productPrice;
    private int _quantity;

    public Product(string productName, string productId, int price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _productPrice = price;
        _quantity = quantity;
    }

    public int TotalPrice()
    {
        return _productPrice * _quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductId()
    {
        return _productId;
    }
}
