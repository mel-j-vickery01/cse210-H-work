

class Reference
{
    private string _bookName;
    private string _text;
    private int _chapter;
    private int _verse;
    private int _startvers;
    private int _endvers;


    public Reference(string bookName, int chapter, int verse)
    {
        _bookName = bookName;
        _chapter = chapter;
        _verse = verse;
        _startvers = -1;
        _endvers = -1;
    }

    public Reference(string bookName, int chapter, int startVers, int endVers)
    {
        _bookName = bookName;
        _chapter = chapter;
        _verse = -1;
        _startvers = startVers;
        _endvers = endVers;
    }

    private string getreferencestring();
    {
        
    }
    public void showreference();
    {

    }

    public string getreference();
    {

    }
}