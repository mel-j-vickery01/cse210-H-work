

class Reference
{
    private string _bookName;
    private int _chapter;
    private int _startvers;
    private int _endvers;


    public Reference(string bookName, int chapter, int startvers)
    {
        _bookName = bookName;
        _chapter = chapter;
        _startvers = startvers;
        _endvers = -1;
    }

    public Reference(string bookName, int chapter, int startVers, int endVers)
    {
        _bookName = bookName;
        _chapter = chapter;
        _startvers = startVers;
        _endvers = endVers;
    }

    public void showreference()
    {
        Console.WriteLine($"{_bookName} {_chapter} : {_startvers}");
    }

    public string GetReference()
    {
        string line = $"{_bookName} {_chapter} : {_startvers} ";
        if (_endvers != -1)
        {
            line = string.Concat(line,$"- {_endvers}" );
        }
        return line;
    }
}