class BreathingActivity : ActivityManager
{

    public void Run()
    {
        BeginActivity("Breathing", "You will relax yourself by participating in a deep breathing activity for the amount of time that you have set! Relax and let's get started!");

        DateTime startime = DateTime.Now;
        DateTime endtime = startime.AddSeconds(GetDuration());
        // int ElaspedTime = 0;
        while (DateTime.Now < endtime)
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