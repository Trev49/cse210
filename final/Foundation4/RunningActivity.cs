public class RunningActivity : Activity
{
    public double Distance { get; set; }

    public RunningActivity(DateTime date, int durationMinutes, double distance)
        : base(date, durationMinutes)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
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
