using System;

class Program
{
    static void DisplayMenu()
    {
        Console.WriteLine("Menu");
        Console.WriteLine(" 1. Add new job");
        Console.WriteLine(" 2. Display Resume");
        Console.WriteLine(" 3. Quit");
    }
    static void Main(string[] args)
    {
        Resume theResume = new Resume();
        bool KeepRunning = true;
        while (KeepRunning)
        {
            DisplayMenu();
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // add new job
                Console.Write("What is the name of the company?");
                string company = Console.ReadLine();
                Console.Write("What is the position?");
                string position = Console.ReadLine();

                Job newJob = new Job();
                newJob._company = company;
                newJob._jobTitle = position;
                newJob._startYear = 2015;
                newJob._endYear = 2025;

                theResume._jobs.Add(newJob);
            }
            else if (choice == "2")
            {
                // display the resume
                theResume.Display();
            }
            else if (choice == "3")
            {
                // quit
                KeepRunning = false;
            }
            else
            {
                Console.WriteLine("Sorry, That is not valid. Please try again. ");
            }
        }

        // new Object
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}