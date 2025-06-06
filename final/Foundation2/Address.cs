class Address
{
    private string _StreetAddress;
    private string _City;
    private string _StateOrProvince;
    private string _Country;


    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _StreetAddress = streetAddress;
        _City = city;
        _StateOrProvince = stateOrProvince;
        _Country = country;
    }


    public bool IsInUSA()
    {
        return _Country.ToLower() == "usa";
    }


    public string GetFullAddress()
    {
        return $"{_StreetAddress}\n{_City}, {_StateOrProvince}\n{_Country}";
    }
}