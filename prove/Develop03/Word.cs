
using System.Runtime.CompilerServices;

class Word
{

    private string _word;
    private bool _hidden;

    Word(string word)
    {
        _word = word;
        _hidden = false;
    }



    public void SetHidden()
    {
        _hidden = true;
    }



    public string GetWord()
    {
        if (!_hidden)
        {
            return _word;
        }
        else
        {
            return "___";
        }
    }
















}