class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> Comments;

    public string Title { get => _title; set => _title = value; }
    public string Author { get => _author; set => _author = value; }
    public int Length { get => _length; set => _length = value; }
    internal List<Comment> Comments1 { get => Comments; set => Comments = value; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments1 = new List<Comment>();
    }

    public void AddComment(string name, string text)
    {
        Comments.Add(new Comment(name, text));
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }

}