using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the Magic Number? :");
        string userSetGuess = Console.ReadLine();
<<<<<<< HEAD
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
=======
        int magicNumber = int.pars(userSetGuess);

        Console.Write("What is your guess? :");
        string userInputGuess = Console.ReadLine();
        int userGuess = int.pars(userInputGuess);

        if (userGuess > magicNumber)
        {
            Console.WriteLine("Guess lower")
        }

>>>>>>> 8602b8e6fb89ccb6792407d2ba3bc84b45aed330
    }
}