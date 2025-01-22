using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        string adjective = GetAdjective();
        string noun = GetNoun();

        int number = Multiply(3, 4);

        Console.WriteLine($"I looked out the window and saw a {adjective} {noun}");
    }
    // Functions must have data type and () after function name.

    static int Multiply(int number1, int number2)
    {
        int product = number1 * number2;
        return product;
    }
    static string GetAdjective()
    {

        Console.WriteLine("Enter an Adjective");
        string Adjective = Console.ReadLine();
        return Adjective;
    }
    static string GetNoun()
    {
        Console.WriteLine("Enter a noun");
        string Noun = Console.ReadLine();
        return Noun;
    }
}