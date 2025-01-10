using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi There! Great to see you!");
        Console.WriteLine("What's your name?");
        string First_name = Console.ReadLine();
        Console.WriteLine("Now, what's your last name?");
        string Last_name = Console.ReadLine();
        Console.WriteLine($"Nice to meet you {First_name} {Last_name}!");

        Console.WriteLine($"{First_name} Please enter your grade percentage: ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"{First_name} You have an: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine($"Also {First_name} You passed! Way to go!");
        }
        else
        {
            Console.WriteLine($"Sorry {First_name} you didn't pass evaluate and try again!");
        }
    }
}