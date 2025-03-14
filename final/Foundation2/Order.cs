class Order
{
    private List<Product> _Products;
    private Customer _Customer;


    public Order(Customer customer)
    {
        _Customer = customer;
        _Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _Products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalProductCost = 0;

        foreach (var product in _Products)
        {
            totalProductCost += product.GetTotalCost();
        }

        double shippingCost = _Customer.LivesInUSA() ? 5 : 35;
        return totalProductCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";

        foreach (var product in _Products)
        {
            label += product.GetProductLabel() + "\n";
        }

        return label;
    }


    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_Customer.GetName()}\n{_Customer.GetAddress()}";
    }
}
