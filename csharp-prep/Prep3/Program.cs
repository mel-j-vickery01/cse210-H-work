using System;

class Program
{



    static void Main(string[] args)
    {
        Random randomGenerater = new Random();

        string answer = "wrong";

        string playGame = "Y";
        int numberOfGuess = 0;
        while (playGame == "Y")
        {
            int magicNumber = randomGenerater.Next(1, 25);
            while (answer == "wrong")
            {


                Console.Write("What is your guess? :");
                string userInputGuess = Console.ReadLine();
                int userGuess = int.Parse(userInputGuess);


                if (userGuess > magicNumber)
                {
                    Console.WriteLine("Guess lower");
                    playGame = "N";
                    numberOfGuess += 1;
                }
                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Guess Higher");
                    playGame = "N";
                    numberOfGuess += 1;

                }
                if (userGuess == magicNumber)
                {
                    numberOfGuess += 1;
                    Console.WriteLine("You Guessed the Magic Number!!!");
                    Console.WriteLine($"You got the number in {numberOfGuess} guesses");

                    answer = "correct";
                }

            }
            Console.WriteLine("Would you like to play again? (Y/N)");


            string reply = Console.ReadLine();
            if (reply == "Y")
            {
                playGame = "Y";
                answer = "wrong";
            }
        }

    }
}