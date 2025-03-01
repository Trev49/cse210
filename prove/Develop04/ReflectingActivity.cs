using System.Formats.Asn1;

class ReflectingActivity : ActivityManager
{
    public void Run()
    {

        BeginActivity("Reflection Activity", "This Activity wll help you reflect on some great times in life recently to help you get through the upcoming challenges up your way!\n\n\n");
        ShowAnimation(5);

        string[] Prompts = new string[]
        {
            "Think of a time when you helped someone in need.",
            "Think of a time when you pushed through a really hard time in life and what you became because of it.",
            "Think of a time when you felt the hand of the Lord in your life for you or a loved one",
            "Think of your purpose in this life and ponder why your life is the way it is."
        };

        Random random = new Random();
        string DisplayedPrompt = Prompts[random.Next(Prompts.Length)];

        Console.WriteLine(DisplayedPrompt);

        string[] Questions = new string[]
       {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
       };

        DateTime StartTime = DateTime.Now;
        DateTime endtime = StartTime.AddSeconds(GetDuration());
        // int ElaspedTime = 0;
        string filePath = "listedItems.txt";

        using (StreamWriter writer = new StreamWriter(filePath, append: true))
        {
            writer.WriteLine("----- Reflecting Activity -----");
            writer.WriteLine($"Start Time: {StartTime}");
            while (DateTime.Now < endtime)
            {
                string Question = Questions[random.Next(Questions.Length)];
                Console.WriteLine(Question);
                string Answer = Console.ReadLine();
                ShowAnimation(3);
                writer.WriteLine(Answer);
                // ElaspedTime += 6;
            }
        }

        FinishActivity("Reflection");
    }
}

