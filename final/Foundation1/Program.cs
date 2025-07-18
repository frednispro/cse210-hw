using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create sample videos
        Video video1 = new Video("Learn C#", "John Smith", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks."));
        video1.AddComment(new Comment("Charlie", "Can you make one on LINQ?"));

        Video video2 = new Video("Cooking Pasta", "Chef Mario", 480);
        video2.AddComment(new Comment("Diana", "Yummy recipe!"));
        video2.AddComment(new Comment("Eve", "Can't wait to try this."));
        video2.AddComment(new Comment("Frank", "What sauce did you use?"));

        List<Video> videos = new List<Video>() { video1, video2 };

        // Display each video's details
        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {v.Title}");
            Console.WriteLine($"Author: {v.Author}");
            Console.WriteLine($"Length: {v.Length} seconds");
            Console.WriteLine($"Comments ({v.GetCommentCount()}):");
            foreach (Comment c in v.Comments)
            {
                Console.WriteLine($"  {c.Name}: {c.Text}");
            }
            Console.WriteLine();
        }
    }
}
