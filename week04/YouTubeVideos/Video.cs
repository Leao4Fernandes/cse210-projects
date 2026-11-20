namespace YouTubeVideos;
public class Video
{
    private string _tittle;
    private string _author;
    private int _lengthVideo;
    private List<Comment> _comments = new List<Comment>();

    public Video(string tittle, string author, int lengthVideo)
    {
        _tittle = tittle;
        _author = author;
        _lengthVideo = lengthVideo;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int NumberComments()
    {
        int numberComment =_comments.Count();
        return numberComment;
    }

    public void displayVideo()
    {
        Console.WriteLine($"Title: {_tittle}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthVideo} seconds");
        Console.WriteLine($"Number of Comments: {NumberComments()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }

}
