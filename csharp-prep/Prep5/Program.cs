using System;

class Program
{
    static void Main(string[] args)
    {
        {
            Welcome();

            string user = GetName();
            int userNumber = GetNumber();

            int squared = SquareNumber(userNumber);

            Result(user, squared);
        }

        static void Welcome()
        {
            Console.WriteLine("Welcome to the number Square program!");
        }

        static string GetName()
        {
            Console.Write("First, What's your name?: ");
            string name = Console.ReadLine();
            Console.Write($"Nice to meet you {name}!\n");

            return name;
        }

        static int GetNumber()
        {
            Console.Write("What's your favorite number(Mine is 37): ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void Result(string name, int square)
        {
            Console.WriteLine($"Ok {name}, the square of your number is {square}");
        }
    }
}
