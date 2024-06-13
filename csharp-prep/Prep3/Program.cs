using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the Magic Number? :");
        string userSetGuess = Console.ReadLine();
        int magicNumber = int.Parse(userSetGuess);


        string answer = ("yes");

        while (answer == "yes")
        {
                Console.Write("What is your guess? :");
        string userInputGuess = Console.ReadLine();
        int userGuess = int.Parse(userInputGuess);


        if (userGuess > magicNumber)
        {
            Console.WriteLine("Guess lower");
        }
        if (userGuess < magicNumber)
        {
            Console.WriteLine("Guess Higher");
        }
        if (userGuess == magicNumber)
        {
            Console.WriteLine("You Guessed the Magic Number!!!");
            answer = "no";
        }
        }
    }
}