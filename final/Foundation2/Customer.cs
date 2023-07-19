using System;

class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }

    public bool InUSA()
    {
        return _customerAddress.InUSA();
    }

    public string GetName()
    {
        return _customerName;
    }

    public Address GetAddress()
    {
        return _customerAddress;
    }
}
