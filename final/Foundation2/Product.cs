class Product
{
    private string _Name;
    private string _ProductId;
    private double _PricePerUnit;
    private int _Quantity;

    public Product(string Name, string ProductId, double PricePerUnit, int Quantity)
    {
        _Name = Name;
        _ProductId = ProductId;
        _PricePerUnit = PricePerUnit;
        _Quantity = Quantity;
    }

    public double GetTotalCost()
    {
        return _PricePerUnit * _Quantity;
    }

    public string GetProductLabel()
    {
        return $"{_Name} (ID: {_ProductId})";
    }
}