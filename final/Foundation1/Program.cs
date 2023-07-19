using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Video video1 = new Video("The Return of Manny the Leader", "Micheal Stan", 600);
        video1.AddComment("Massy109", "Great video!");
        video1.AddComment("Josh4life", "Nice content!");
        video1.AddComment("NPCrules", "Keep it up!");

        Video video2 = new Video("How to Study Effectively", "Emmanuel Ologe", 400);
        video2.AddComment("GiwaS", "Interesting video!");
        video2.AddComment("Wingsflying", "Well explained.");
        video2.AddComment("shredded", "I learned a lot.");

        Video video3 = new Video("Be Happy In Gratitude ", "Sunday sunshines", 180);
        video3.AddComment("Summer222", "Short and sweet!");
        video3.AddComment("ezmalay", "Amazing!");

        List<Video> listOfVideos = new List<Video> { video1, video2, video3 };

        foreach (Video video in listOfVideos)
        {
            video.Display();
        }
    }
}
