class Activity
{



    public void Spinner()
    {
        
        for(int i = 0; i < 3; i++)
        {
        Console.Write("|");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(500);

        Console.Write("\b \b");
        }
    }
    public void DisplayInstructions(string instructionStr)
    {
        Console.WriteLine(instructionStr);
    }
    public void EndMessage(string endActivity)
    {
Console.WriteLine($"\n{endActivity}");
    }
    public int PromptForTime()
    {
        Console.Write("How long would you like to do this exercise? : ");
        int setTime = int.Parse(Console.ReadLine());
        return setTime;
    }


}