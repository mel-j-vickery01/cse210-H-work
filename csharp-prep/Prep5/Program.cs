using System;

class Program
{
    static void Main()
    {
        DIsplayWelcom();
        string userName = PromptUserName();
        int favoritNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoritNumber);
        DisplayResult(userName, squaredNumber);
    }
    static void DIsplayWelcom()
    {
        Console.WriteLine("Welcome to the Program");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name?: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorit number?: ");
        string inputNumber = Console.ReadLine();
        int favNumber = int.Parse(inputNumber);
        return favNumber;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string inName, int numberSquare)
    {
        Console.Write($"{inName}, ");
        Console.WriteLine($"the square of your number is {numberSquare}");
    }
}