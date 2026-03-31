using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

         List<Video> videos = new List<Video>();

        Video v1 = new Video("C# Basics", "Mary Tech", 600);
        v1.AddComment(new Comment("John", "Great video!"));
        v1.AddComment(new Comment("Anna", "Very helpful."));
        v1.AddComment(new Comment("Mike", "Nice explanation."));

      
        Video v2 = new Video("Web Development", "Code Master", 900);
        v2.AddComment(new Comment("Sarah", "Loved it!"));
        v2.AddComment(new Comment("Paul", "Very detailed."));
        v2.AddComment(new Comment("Grace", "Awesome content."));

        Video v3 = new Video("Python Tutorial", "Dev Hub", 750);
        v3.AddComment(new Comment("Tom", "Easy to follow."));
        v3.AddComment(new Comment("Lucy", "Thanks for sharing."));
        v3.AddComment(new Comment("James", "Helpful tutorial."));

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine("\n----------------------\n");
        }
    }
}