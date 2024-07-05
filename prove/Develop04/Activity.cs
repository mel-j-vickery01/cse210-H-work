class Activity
{

    private int _duration;
    private string _title;
    private string _description;
    private DateTime _endTime;

    public Activity(string title, string description)
    {
        _title = title;
        _description = description;
    }

    public void Spinner()
    {

        for (int i = 0; i < 3; i++)
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
    public void DisplayWelcome()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_title} Activity");
    }
    public void DisplayInstruction()
    {
        Console.WriteLine(_description);
    }
    public void EndMessage(string endActivity)
    {
        Console.WriteLine($"\n{endActivity}");
    }
    public void PromptForTime()
    {
        Console.Write("How long would you like to do this exercise? : ");
        _duration = int.Parse(Console.ReadLine());
        DateTime currentTime = DateTime.Now;
        _endTime = currentTime.AddSeconds(_duration);
    }
    public bool Timer()
    {
        DateTime currentTime = DateTime.Now;
        if (currentTime > _endTime)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void CountDown(int timerlength)
    {
        for (int i = timerlength; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(800);
            Console.Write("\b \b");

        }
    }


}