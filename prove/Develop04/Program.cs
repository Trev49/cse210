using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{

    private static int _InvalidCounter = 0;
    static bool Continue = true;
    static void Main(string[] args)
    {

        while (Continue == true)
        {
            DisplayMenu();
        }
    }

    public static void DisplayMenu()
    {
        // Console.Clear();
        Console.WriteLine("Welcome to The mindfulness activity! Please choose an activity below");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit the program");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            BreathingActivity breathingActivity = new BreathingActivity();
            breathingActivity.Run();
        }
        else if (choice == "2")
        {
            ReflectingActivity reflectionActivity = new ReflectingActivity();
            reflectionActivity.Run();
        }
        else if (choice == "3")
        {
            ListingActivity listingActivity = new ListingActivity();
            listingActivity.Run();
        }
        else if (choice == "4")
        {
            Continue = false;
        }
        else
        {
            Console.WriteLine("Please Try again. You didn't enter a valid choice.\n");
            _InvalidCounter++;
            if (_InvalidCounter > 5)
            {
                Console.WriteLine("Looks like you have enetered too many invalid choices. lets go to the breathing Activity and relax.\n\n");
                Thread.Sleep(1000);
                BreathingActivity breathingActivity = new BreathingActivity();
                _InvalidCounter = 0;
                breathingActivity.Run();
            }
        }
    }



}
