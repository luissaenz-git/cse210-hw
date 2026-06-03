public class Comment
{
    private string _commmentAuthor = "";
    private string _commentText = "";

    public Comment(string author, string text)
    {
        _commmentAuthor = author;
        _commentText = text;
    }

    public string GetCommentInfo()
    {
        return $"Author: {_commmentAuthor}, Comment: {_commentText}";
    }

}