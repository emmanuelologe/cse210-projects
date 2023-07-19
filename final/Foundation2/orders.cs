using System;
using System.Collections.Generic;

class Order
{
    private List<Product> _products;
    private Customer _customer;
    private int _shippingCost;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
        _shippingCost = _customer.InUSA() ? 5 : 35;
    }

    public int CalculateTotalCost()
    {
        int totalCost = _shippingCost;

        foreach (var product in _products)
        {
            totalCost += product.TotalPrice();
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";

        foreach (var product in _products)
        {
            packingLabel += $"{product.GetProductName()} (ID: {product.GetProductId()})\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";

        return shippingLabel;
    }
}
