using System;
using System.Collections.Generic;

public class Order
{
    private Customer _customer;
    private List<Product> _products;
    private double _totalPrice; // Add a private field to store the total price

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
        _totalPrice = CalculateTotalPrice(); // Calculate the total price only once during object creation
    }

    public double CalculateTotalPrice()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.CalculateTotalPrice();
        }

        total += _customer.IsInUSA() ? 5 : 35;

        return total;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"Product Name: {product.GetName()}, Product ID: {product.GetProductId()}, Quantity: {product.GetQuantity()}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"Customer Name: {_customer.GetName()}\n";
        shippingLabel += _customer.GetAddress().GetFullAddressString();

        return shippingLabel;
    }

    public double GetTotalPrice()
    {
        return _totalPrice;
    }
}
