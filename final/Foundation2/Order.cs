using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalPrice();
        }

        if (_customer.IsInUSA())
            total += 5;
        else
            total += 35;

        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Packing Label:");
        foreach (var product in _products)
        {
            sb.AppendLine($"{product.Name} (ID: {product.ProductId})");
        }
        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        return $"Shipping To:\n{_customer.Name}\n{_customer.GetAddressString()}";
    }
}
