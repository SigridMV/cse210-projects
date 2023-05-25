using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Wonderwall", "Oasis", 300);
        Video video2 = new Video("Let it be", "The beatles", 500);
        Video video3 = new Video("The A Team", "Ed Sheeran", 400);

        video1.AddComment("Rosa Vidal", "Great Video!");
        video1.AddComment("Elias Zúñiga", "I love it!");
        video1.AddComment("Pablo Machel", "Boring");

        video2.AddComment("Génesis Fernández", "I didn't like it");
        video2.AddComment("Naima Zúñiga", "I like it");
        video2.AddComment("Jonathan Riquelme", "Fun");

        video3.AddComment("Jennifer Becerra", "Awesome");
        video3.AddComment("Ignacio Gutierrez", "This video looks great!");
        video3.AddComment("Carolina Torres", "This video is amazing!");
        video3.AddComment("Josefa Hidalgo", "Cool!");

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Duration: " + video.Length + " seconds");
            Console.WriteLine("Amount of comments: " + video.GetCommentCount());
            Console.WriteLine();
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments1)
            {
                Console.WriteLine("Who commented on it: " + comment.Name);
                Console.WriteLine("What commented on it: " + comment.Text);
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}