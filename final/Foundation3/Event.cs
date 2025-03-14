public class Event
{
    private string _Title;
    private string _Description;
    private DateTime _Date;
    private TimeSpan _Time;
    private Address _EventAddress;

    public Event(string Title, string Description, DateTime Date, TimeSpan Time, Address Address)
    {
        _Title = Title;
        _Description = Description;
        _Date = Date;
        _Time = Time;
        _EventAddress = Address;
    }

    public string Title
    {
        get { return _Title; }
        set { _Title = value; }
    }

    public string Description
    {
        get { return _Description; }
        set { _Description = value; }
    }

    public DateTime Date
    {
        get { return _Date; }
        set { _Date = value; }
    }

    public TimeSpan Time
    {
        get { return _Time; }
        set { _Time = value; }
    }

    public Address EventAddress
    {
        get { return _EventAddress; }
        set { _EventAddress = value; }
    }

    public string GetStandardDetails()
    {
        return $"{Title}\n{Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {EventAddress.FormatAddress()}";
    }

    public string GetShortDescription()
    {
        return $"{GetType().Name} - {Title}\nDate: {Date.ToShortDateString()}";
    }
}
