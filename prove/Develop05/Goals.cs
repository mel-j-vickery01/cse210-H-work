class Goals
{
    List<Goal> goals = new List<Goal>();
    private int _totalScore;
    private string fileName = "goals2.txt";
    public Goals()
    { }
    public void DisplayGoals()
    {
        Console.WriteLine();
        int count = 1;
        Console.WriteLine($"your Score:{_totalScore}");
        foreach (Goal i in goals)
        {
            Console.WriteLine($"{count}. {i}");
            count++;
        }
        Console.WriteLine();
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }
    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you want to report on?");
        DisplayGoals();
        int input = int.Parse(Console.ReadLine());
        _totalScore += goals[input-1].ReportEvent();
    }
    public void SaveGoals()
    {
        using StreamWriter outputFile = new StreamWriter(fileName);
        {
            outputFile.WriteLine($"score#{_totalScore}");
            foreach (Goal i in goals)
            {
                outputFile.WriteLine(i.ToFile());
            }
        }
    }
    public void LoadGoals()
    {
        string[] lines = File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] items = line.Split("#");
            string goalType = items[0];
            if(goalType == "score")
            {
                _totalScore = int.Parse(items[1]);
            }
            else if (goalType == "Simple")
            {
                string name = items[1];
                string discription = items[2];
                int points = int.Parse(items[3]);
                bool status = bool.Parse(items[4]);
                Simple simple = new Simple(name, discription, points, status);
                simple.SetGoalType(goalType);
                goals.Add(simple);
            }
        }
    }
}