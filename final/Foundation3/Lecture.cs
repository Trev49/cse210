public class Lecture : Event
{
    private string _Speaker;
    private int _Capacity;

    public Lecture(string Title, string Description, DateTime Date, TimeSpan Time, Address Address, string Speaker, int Capacity)
        : base(Title, Description, Date, Time, Address)
    {
        _Speaker = Speaker;
        _Capacity = Capacity;
    }

    public string Speaker
    {
        get { return _Speaker; }
        set { _Speaker = value; }
    }

    public int Capacity
    {
        get { return _Capacity; }
        set { _Capacity = value; }
    }

    public string GetLectureFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}
