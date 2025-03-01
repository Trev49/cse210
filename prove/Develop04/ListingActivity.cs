class ListingActivity : ActivityManager
{

    public void Run()
    {
        BeginActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        string[] Prompts = new string[]
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random random = new Random();
        string DisplayedPrompt = Prompts[random.Next(Prompts.Length)];
        Console.WriteLine(DisplayedPrompt);

        DateTime StartTime = DateTime.Now;
        DateTime endtime = StartTime.AddSeconds(GetDuration());
        //int ElaspedTime = 0;
        int ItemsListed = 0;
        string filePath = "listedItems.txt";

        using (StreamWriter writer = new StreamWriter(filePath, append: true))
        {
            writer.WriteLine("----- New Listing Activity -----");
            writer.WriteLine($"Start Time: {StartTime}");
            while (DateTime.Now < endtime)
            {
                Console.Write("Please list an item. ");
                string Item = Console.ReadLine();
                if (string.IsNullOrEmpty(Item))
                {
                    break;
                }
                ItemsListed++;
                writer.WriteLine(Item);
                // ElaspedTime += 5;
            }
        }

        Console.WriteLine($"Time's up! you were able to list {ItemsListed} items.");
        FinishActivity("Listing");
    }

}