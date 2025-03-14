class Customer
{
    private string _Name;
    private Address _Address;


    public Customer(string name, Address address)
    {
        _Name = name;
        _Address = address;
    }

    public string GetName()
    {
        return _Name;
    }

    public bool LivesInUSA()
    {
        return _Address.IsInUSA();
    }

    public string GetAddress()
    {
        return _Address.GetFullAddress();
    }
}
