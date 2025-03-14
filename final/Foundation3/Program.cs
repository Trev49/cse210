using System;

class Program
{
    static void Main()
    {
        Address eventAddress = new Address("123 Main St", "Cityville", "ST", "12345");


        Lecture lecture = new Lecture(
            "Gospel Talk: Why Scripture Study is Important",
            "A lecture describing the importance of scripture study.",
            new DateTime(2025, 5, 1),
            new TimeSpan(18, 0, 0),
            eventAddress,
            "Dr. John Smith",
            100);


        Reception reception = new Reception(
            "Wedding Reception",
            "A formal reception for the Newly married couple the Smith's.",
            new DateTime(2025, 6, 15),
            new TimeSpan(19, 0, 0),
            eventAddress,
            "rsvp@company.com");


        OutdoorGathering outdoorGathering = new OutdoorGathering(
            "Beach Picnic",
            "Volleyball, swimming, surfing, and more!",
            new DateTime(2025, 7, 20),
            new TimeSpan(12, 0, 0),
            eventAddress,
            "Sunny");

        Console.WriteLine("Lecture Event:");
        Console.WriteLine(lecture.GetLectureFullDetails());
        Console.WriteLine();

        Console.WriteLine("Reception Event:");
        Console.WriteLine(reception.GetReceptionFullDetails());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Event:");
        Console.WriteLine(outdoorGathering.GetOutdoorGatheringFullDetails());
        Console.WriteLine();
    }
}
