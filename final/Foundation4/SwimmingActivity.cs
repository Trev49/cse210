public class SwimmingActivity : Activity
{
    public int Laps { get; set; }

    public SwimmingActivity(DateTime date, int durationMinutes, int laps)
        : base(date, durationMinutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        double distanceInKm = Laps * 50 / 1000.0;
        return distanceInKm * 0.62;
    }


    public override double GetSpeed()
    {
        return (GetDistance() / DurationMinutes) * 60;
    }

    public override double GetPace()
    {
        return DurationMinutes / GetDistance();
    }
}
