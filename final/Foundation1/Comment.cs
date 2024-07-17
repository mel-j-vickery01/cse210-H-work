class Comment
{
    private string _name;
    private string _text;

    public string MakeComment()
    {
        Console.Write("Who made the Comment?: ");
        _name = Console.ReadLine();
        Console.Write("What does the comment say?: ");
        _text = Console.ReadLine();
        return $"{_name}, said : {_text}";
    }
}
