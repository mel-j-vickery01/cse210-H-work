class Video
{

    private string _title;
    private string _author;
    private int _vidLength;

    List<Comment> _comments = new List<Comment>();

    public void SetText()
    {
        Console.Write("What is the title of the video?: ");
        _title = Console.ReadLine();
        Console.Write("Who made the video?: ");
        _author = Console.ReadLine();
        Console.Write("How long is the video?: ");
        _vidLength = int.Parse(Console.ReadLine());

    }
    public void Display()
    {
        Console.WriteLine($"{_title}, made by {_author}, Video is {_vidLength} seconds long");
        Console.Write("Comments: ");
        DisplayComments();
    }
    public string GetTitle()
    {
        return _title;
    }
    public string Getauthor()
    {
        return _author;
    }
    public void DisplayComments()
    {
        foreach (Comment i in _comments)
        {
            Console.WriteLine(i);
        }
    }
    public void AddComment()
    {
        bool input = false;
        while (!input)
        {
            string response;

            Comment comment = new Comment();
            comment.MakeComment();
            _comments.Add(comment);
            Console.Write("Add another Comment? (Y/N): ");
            response = Console.ReadLine();

            if (response == "N")
            {
                input = true;
            }

        }

    }
}