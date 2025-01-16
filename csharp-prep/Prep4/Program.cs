using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Please enter a number: If you would like to exit please press 0) ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);


            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }


        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");



        float aver = ((float)sum) / numbers.Count;
        Console.WriteLine($"The aver is: {aver}");


        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max number in the list is: {max}");
    }
}