public class Reception : Event
{
    private string _RsvpEmail;

    public Reception(string Title, string Description, DateTime Date, TimeSpan Time, Address Address, string RsvpEmail)
        : base(Title, Description, Date, Time, Address)
    {
        _RsvpEmail = RsvpEmail;
    }

    public string RsvpEmail
    {
        get { return _RsvpEmail; }
        set { _RsvpEmail = value; }
    }

    public string GetReceptionFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Reception\nRSVP Email: {RsvpEmail}";
    }
}
