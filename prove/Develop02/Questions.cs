using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using System.Collections.Generic;


class Questions
{
    List<string> _questions = new List<string>();
    public void makeList()
    {



        _questions.Add("Who was the most interesting person I interacted with today?");
        _questions.Add("What was the best part of my day?");
        _questions.Add("How did I see the hand of the Lord in my life today?");
        _questions.Add("What was the strongest emotion I felt today?");
        _questions.Add("If I had one thing I could do over today, what would it be?");
        _questions.Add("What are some names I heard today?");
        _questions.Add("What is one small that I have improved today?");
        _questions.Add("Did I make my bed? What did I finish today?");
    }
    public string Prompt()
    {
        makeList();
        int length = _questions.Count;

        Random randomGenerater = new Random();
        int randPrompt = randomGenerater.Next(length);

        string randomPrompt = _questions[randPrompt];
        return randomPrompt;
    }
}