using System;

public class Video
{
    private string _title = "";
    private string _author = "";

    private int _durationInSeconds = 0;

    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int durationInSeconds)
    {
        _title = title;
        _author = author;
        _durationInSeconds = durationInSeconds;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public string GetCommentsInfo()
    {
        string commentsInfo = "";
        foreach (Comment comment in _comments)
        {
            commentsInfo = commentsInfo + "\n" + comment.GetCommentInfo();
        }
        return commentsInfo;
    }

    public string GetVideoInfo()

    {
        return $"Title: {_title}, Author: {_author}, Duration: {_durationInSeconds} seconds, Number of Comments: {GetNumberOfComments()}, \nComments:{GetCommentsInfo()}";
    }
}


