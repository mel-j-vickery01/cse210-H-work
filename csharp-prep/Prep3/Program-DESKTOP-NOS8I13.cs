using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the Magic Number? :");
        string userSetGuess = Console.ReadLine();
        int magicNumber = int.pars(userSetGuess);

        Console.Write("What is your guess? :");
        string userInputGuess = Console.ReadLine();
        int userGuess = int.pars(userInputGuess);

        if (userGuess > magicNumber)
        {
            Console.WriteLine("Guess lower")
        }

    }
}