
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

class Word
{

    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }



    public void SetHidden()
    {
            _hidden = true;   
    }

    public bool isHidden()
    {
        return _hidden;
    }


    private string UnderLine()
    {
        if (_hidden == false)
        {
            return _word;
        }
        else
        {
            int length = _word.Length;
            string underScores = string.Concat(Enumerable.Repeat("_", length));
            return underScores;



        }
    }

    public void Display()
    {
        Console.Write($"{UnderLine()} ");
    }

















}