using System;

class Program
{
    static void Main(string[] args)
    {
        string inPut = "0";
        do
        {
        Console.WriteLine("1. write a new Entery");
        Console.WriteLine("2. Display Journal");
        Console.WriteLine("3. Read Journal from file");
        Console.WriteLine("4. Write Journal to file");
        Console.WriteLine("5. Quit");
        inPut = Console.ReadLine();

        if (inPut == "1")
        {
            Console.WriteLine("tell me you're working");
        }
        }while (inPut != "5");
    }
}