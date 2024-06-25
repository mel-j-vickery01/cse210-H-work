using System;

string journalFilePath = "journal.txt";
var journal = new Journal(journalFilePath);
Questions prompt = new Questions();

string inPut = "0";
do
{
    Console.WriteLine("\n1. write a new Entry");
    Console.WriteLine("2. Read Entry [Not Saved To File]");
    Console.WriteLine("3. Save Journal to file");
    Console.WriteLine("4. Read from current file");
    Console.WriteLine("5. Quit\n");
    Console.Write("\nWhat would you like Today? : ");
    inPut = Console.ReadLine();

    if (inPut == "1")
    {
        
        Console.WriteLine(prompt.Prompt());
        Console.Write("Enter your Journal Entry: ");
        string entry = Console.ReadLine();
        journal.add(entry);
    }
    if (inPut == "2")
    {
        journal.read();
    }

    if (inPut == "3")
    {   
        string entry = File.ReadAllText(journalFilePath);
        journal.writeToText();
    }
    if (inPut == "4")
    {
        journal.readFromText();
    }

} while (inPut != "5");
