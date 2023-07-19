using System;

public class Comment
{
    private string _viewerUserName;
    private string _viewerComment;

    public Comment(string viewerName, string viewerComment)
    {
        _viewerUserName = viewerName;
        _viewerComment = viewerComment;
    }

    public string GetCommentInfo()
    {
        return $"{_viewerUserName}: {_viewerComment}";
    }
}
