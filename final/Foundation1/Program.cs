using System;

class Program
{
    static void Main(string[] args)
    {

        Video video1 = new Video("The Refiner's Fire", "Alice", 300);
        video1.AddComment(new Comment("Bob", "I look to this video everytime I feel down"));
        video1.AddComment(new Comment("Charlie", "These videos are the best!"));
        video1.AddComment(new Comment("David", "Miracles can happen through God's gospel as long as you turn to him."));

        Video video2 = new Video("Learn C# Programming", "John", 600);
        video2.AddComment(new Comment("Eve", "This tutorial is really helpful!"));
        video2.AddComment(new Comment("Frank", "Can you add more examples?"));

        Video video3 = new Video("Travel Vlog: Paris", "Sophia", 1200);
        video3.AddComment(new Comment("Grace", "Loved the Eiffel Tower footage!"));
        video3.AddComment(new Comment("Hannah", "This vlog makes me want to visit Paris!"));
        video3.AddComment(new Comment("Ivy", "The food shots were amazing!"));

        Video video4 = new Video("General Conference", "Mark", 90000);
        video4.AddComment(new Comment("Jack", "I always look forward to general conference!"));
        video4.AddComment(new Comment("Lily", "Such inspired people!"));


        List<Video> videos = new List<Video> { video1, video2, video3, video4 };


        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Comments total: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine();
        }
    }
}

