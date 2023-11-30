using System;
using System.Collections.Generic;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }
    public double CalculateTotalCost()
    {
        double totalPrice = _products.Sum(product => product.GetTotalPrice());
        double shippingCost = _customer.IsInUSA() ? 5 : 35;
        return totalPrice + shippingCost;
    }
    public string GetPackingLabel()
    {
        return string.Join("\n", _products.Select(product => $"{product.GetName()} - {product.GetProductId()}"));
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetFullAddress()}";
    }
}