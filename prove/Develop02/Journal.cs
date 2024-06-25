class Journal
{

    private string journalFilePath;
    public Journal(string path)
    {
        journalFilePath = path;
    }


    public void read()
    {
        string content = File.ReadAllText(journalFilePath);
        Console.WriteLine("\nJournal Entry\n");
        Console.WriteLine(content);
        
    }

    public void add(string entry)
    {
        File.AppendAllText(journalFilePath, $"{DateTime.Now}: {entry}\n");
        Console.WriteLine("[test] added succesful");
    }

    public void writeToText()
    {

        
        Console.WriteLine("[TEST] Text writen");
    }

    public void readFromText()
    {
        string readFile = File.ReadAllText(journalFilePath);
        Console.Write(readFile);
    }




}