using System;

public abstract class Activity
{
    public DateTime Date { get; set; }
    public int DurationMinutes { get; set; }

    public Activity(DateTime date, int durationMinutes)
    {
        Date = date;
        DurationMinutes = durationMinutes;
    }


    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }


    public string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {GetType().Name} ({DurationMinutes} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
