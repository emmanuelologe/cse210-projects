using System;
using System.Collections.Generic;

public class Video
{
    private string _videoTitle;
    private string _authorName;
    private int _videoLength;
    private List<Comment> _comments;

    public Video(string videoTitle, string authorName, int videoLength)
    {
        _videoTitle = videoTitle;
        _authorName = authorName;
        _videoLength = videoLength;
        _comments = new List<Comment>();
    }

    public void AddComment(string viewerName, string viewerComment)
    {
        Comment comment = new Comment(viewerName, viewerComment);
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_videoTitle}");
        Console.WriteLine($"Author: {_authorName}");
        Console.WriteLine($"Length (seconds): {_videoLength}");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetCommentInfo());
        }
        Console.WriteLine();
    }
}
