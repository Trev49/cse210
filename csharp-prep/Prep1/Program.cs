using System;
using System.Runtime.ExceptionServices;

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



    }
}