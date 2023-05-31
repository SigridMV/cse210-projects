using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Wonderwall", "Oasis", 300);
        Video video2 = new Video("Let it be", "The beatles", 500);
        Video video3 = new Video("The A Team", "Ed Sheeran", 400);

        video1.AddPositiveComment("Rosa Vidal", "Great Video!");
        video1.AddPositiveComment("Elias Zúñiga", "I love it!");
        video1.AddNegativeComment("Pablo Machel", "Boring");

        video2.AddNegativeComment("Génesis Fernández", "I didn't like it");
        video2.AddPositiveComment("Naima Zúñiga", "Fantastic");
        video2.AddPositiveComment("Jonathan Riquelme", "Fun");

        video3.AddPositiveComment("Jennifer Becerra", "Awesome");
        video3.AddPositiveComment("Ignacio Gutierrez", "This video looks great!");
        video3.AddPositiveComment("Carolina Torres", "This video is amazing!");
        video3.AddNegativeComment("Josefa Hidalgo", "Not Cool!");

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

            Console.WriteLine("Positive Comments:");
            foreach (var comment in video.Comments1)
            {
                if (IsPositiveComment(comment))
                {
                    Console.WriteLine("Who commented on it: " + comment.Name);
                    Console.WriteLine("What commented on it: " + comment.Text);
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Negative Comments:");
            foreach (var comment in video.Comments1)
            {
                if (IsNegativeComment(comment))
                {
                    Console.WriteLine("Who commented on it: " + comment.Name);
                    Console.WriteLine("What commented on it: " + comment.Text);
                    Console.WriteLine();
                }
            }

            Console.WriteLine("-------------------------------------------------------");
        }
    }


    private static bool IsPositiveComment(Comment comment)
    {
        string[] positiveKeywords = { "great", "love", "fun", "awesome", "amazing", "fantastic" };
        foreach (string keyword in positiveKeywords)
        {
            if (comment.Text.ToLower().Contains(keyword))
            {
                return true;
            }
        }
        return false;
    }

    private static bool IsNegativeComment(Comment comment)
    {
        string[] negativeKeywords = { "boring", "didn't like", "not" };
        foreach (string keyword in negativeKeywords)
        {
            if (comment.Text.ToLower().Contains(keyword))
            {
                return true;
            }
        }
        return false;
    }
}


