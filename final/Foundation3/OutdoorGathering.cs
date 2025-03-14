public class OutdoorGathering : Event
{
    private string _WeatherForecast;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _WeatherForecast = weatherForecast;
    }

    public string WeatherForecast
    {
        get { return _WeatherForecast; }
        set { _WeatherForecast = value; }
    }

    public string GetOutdoorGatheringFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {WeatherForecast}";
    }
}
