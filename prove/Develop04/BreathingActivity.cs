class BreathingActivity : ActivityManager
{

    public void Run()
    {
        BeginActivity("Breathing", "You will relax yourself by participating in a deep breathing activity for the amount of time that you have set! Relax and let's get started!");

        DateTime StartTime = DateTime.Now;
        DateTime EndTime = StartTime.AddSeconds(GetDuration());
        // int ElaspedTime = 0;
        while (DateTime.Now < EndTime)
        {
            Console.WriteLine("Inhale");
            ShowAnimation(3);
            Console.WriteLine("Exhale");
            ShowAnimation(3);
            // ElaspedTime += 6;
        }

        FinishActivity("Breathing");
    }
}