using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");


        bool Continue = true;
        int LevelCount = 0;


        Console.WriteLine("Welcome to the scripture Mastery program. As you progress in levels more words will be hidden. Think you can handle it?\n\n");

        // This shows the initial full scripture and reference the scripture is from.  
        Console.WriteLine(reference.GetDisplayText());
        Console.WriteLine(""); // Spacer between this and the verse.
        string FullVerse = scripture.GetDisplayContent();
        Console.WriteLine(FullVerse);

        while (Continue)
        {

            Console.WriteLine("\n\nPress Enter to advance. Type stumped to declare you got stumped or quit to exit");
            string Input = Console.ReadLine().ToLower();

            if (Input == "quit")
            {
                Continue = false;
            }
            else if (Input == "stumped")
            {

                Continue = false;
                Console.WriteLine($"You made it to Level {LevelCount}!\n");
                if (LevelCount > 24)
                {
                    Console.WriteLine("You made it to at least level 25! Good job. Your getting really good at this");

                }
                else if (LevelCount > 14)
                {
                    Console.WriteLine("You made it to at least level 15! Good job. Your on your way into being a master of this scripture!");
                }
                else
                {

                    Console.WriteLine("Nice try! Don't give up! Practice results in progress!");
                }
            }
            else
            {
                if (scripture.AllHidden())
                {
                    Console.WriteLine($"Well. It looks like all words are hidden at level {LevelCount}\n\nDid you get guess it? type y for yes or something else if you didn't.\n ");
                    string LastLevelGotIt = Console.ReadLine().ToLower();
                    if (LastLevelGotIt == "y")
                    {
                        Console.WriteLine($"\nCongrats! You beat the final level of {LevelCount} by getting the scripture! You should try a new scripture!");
                    }
                    else
                    {
                        Console.WriteLine("\nDarn but you made a great effort. You'll get it next time!");
                    }
                    Continue = false;
                }
                else
                {
                    ++LevelCount;
                    scripture.HideRandomWords(3);
                    string text = scripture.GetDisplayContent();
                    Console.WriteLine(text);
                }
            }


        }
    }
}