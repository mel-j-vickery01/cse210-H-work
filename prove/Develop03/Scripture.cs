


class Scripture
{
    private List<Word> _words;
    private Reference _refernce;
    private Random rand = new Random();




    public Scripture(string name, int chapter, int startVerse, string text)
    {
        _words = new List<Word>();
        _refernce = new Reference(name, chapter, startVerse);
        GetListWords(text);
    }

    public string GetReference()
    {
        return _refernce.GetReference();
    }

    public bool IsScriptureHidden()
    {
        foreach ( Word w in _words)
        {
            if (w.isHidden() == false)
            {
                return false;
            }
        }
        return true;
    }

    public void DisplayScripture()
    {
        Console.WriteLine(_refernce.GetReference());
        int length;
        int randomInt;
        bool hidden = false;

        do
        {
            length = _words.Count();
            randomInt = rand.Next(length);
            if (!_words[randomInt].isHidden())
            {
                _words[randomInt].SetHidden();
                hidden = true;
            }

        } while (!hidden);

        foreach (Word w in _words)
        {

            w.Display();
        }
    }

    private void GetListWords(string text)
    {
        foreach (string w in text.Split(" "))
        {
            Word tempWord = new Word(w);
            _words.Add(tempWord);
        }
    }








}