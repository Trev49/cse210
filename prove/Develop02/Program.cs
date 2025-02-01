using System;

class Program
{
    static void Main(string[] args)
    {
        bool KeepGoing = true;
        Journal journal = new Journal();

        Console.WriteLine("Welcome What's your name?");
        string name = Console.ReadLine();
        Console.WriteLine($"Nice to meet you {name}!");


        List<string> prompts = new List<string>
        {
            "Who was the most interesting person you talked to or seen today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What Scriptural story could you relate to based on today's events.",
            "How did you exercice Christlike attributes in your activities today?",
            "Think of your goals, how are you doing with them?"
        };

        while (KeepGoing)
        {

            Console.WriteLine($"Journal Program Menu:                User: {name}");
            Console.WriteLine("");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option (1-5): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {

                Random rand = new Random();
                string randomPrompt = prompts[rand.Next(prompts.Count)];
                Console.WriteLine($"Prompt: {randomPrompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                journal.AddEntry(randomPrompt, response);
            }
            else if (choice == "2")
            {

                journal.DisplayEntries();
                Console.WriteLine("\nPress Enter to continue...");
                Console.Read();
            }
            else if (choice == "3")
            {

                Console.Write("Enter filename to save journal: ");
                string saveFileName = Console.ReadLine();
                journal.SaveToFile(saveFileName);
                Console.WriteLine("\nPress Enter to continue...");
                Console.Read();
            }
            else if (choice == "4")
            {

                Console.Write("Please enter the name of the file you want to load.: ");
                string LoadFile = Console.ReadLine();
                journal.LoadFromFile(LoadFile);
                Console.WriteLine("\nPress ENTER to continue...");
                Console.Read();
            }
            else if (choice == "5")
            {
                bool WroteToday = false;
                DateTime today = DateTime.Now.Date;
                foreach (var entry in journal.Entries)
                {
                    if (entry.Date.Date == today)
                    {
                        WroteToday = true;
                        break;
                    }
                }


                // This checks if the user has written in their journal today. If not the user will be asked if they want to go back to the main menu to write one.
                if (!WroteToday)
                {
                    Console.WriteLine("Oh no! it looks like you have not wrote in your journal today! Do you want to go back to the main menu and do that? Type y then enter to go back to the main menu or type anything else then enter to quit anyway.");
                    string Return = Console.ReadLine();
                    if (Return == "y")
                    {
                        continue;
                    }
                }

                // This will exit the program once the user is done.
                KeepGoing = false;
                Console.WriteLine($"Thank you {name} for using Debo's Journal entry system. Have a nice day!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option, please try again.");
            }
        }
    }
}