class ActivityManager
{
    // BreathingActivity _breathingActivity = new BreathingActivity();
    // ReflectingActivity _reflectionActivity = new ReflectingActivity();
    // ListingActivity _listingActivity = new ListingActivity();
    private int _Time;



    protected void BeginActivity(string Name, string Description)
    {

        Console.WriteLine($"{Name} - {Description}");
        Console.Write("Please enter the duration in seconds that you would like to do this for: ");
        _Time = int.Parse(Console.ReadLine());
        Console.WriteLine("Get Ready!");
        ShowAnimation(5);
    }

    protected void FinishActivity(string name)
    {
        Console.WriteLine($"Times up! You have finished the {name} activity! Way to go!\n\n\n");
    }

    public int GetDuration()
    {
        return _Time;
    }

    protected void ShowAnimation(int duration)
    {
        string Periods = "";
        for (int i = 0; i < duration; i++)
        {
            Periods += ".";
            Console.Write($"{Periods}");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

}
