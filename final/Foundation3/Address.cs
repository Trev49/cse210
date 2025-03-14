public class Address
{
    private string _Street;
    private string _City;
    private string _State;
    private string _ZipCode;

    public Address(string Street, string City, string State, string ZipCode)
    {
        _Street = Street;
        _City = City;
        _State = State;
        _ZipCode = ZipCode;
    }

    public string Street
    {
        get { return _Street; }
        set { _Street = value; }
    }

    public string City
    {
        get { return _City; }
        set { _City = value; }
    }

    public string State
    {
        get { return _State; }
        set { _State = value; }
    }

    public string ZipCode
    {
        get { return _ZipCode; }
        set { _ZipCode = value; }
    }

    public string FormatAddress()
    {
        return $"{_Street}, {_City}, {_State} {_ZipCode}";
    }
}
