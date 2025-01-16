using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the number guessing game!");

        Random Magic = new Random();
        int Number = Magic.Next(1, 1001);

        int guess = 0;

        Console.Write("I'm thinking of a number between 1 and 1000! ");


        while (guess != Number)
        {
            Console.Write("What's your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (Number > guess)
            {
                Console.WriteLine("Go Higher");
            }
            else if (Number < guess)
            {
                Console.WriteLine("Go Lower");
            }
            else
            {
                Console.WriteLine($"You got it! The number was {Number}");
            }
        }
    }
}