class Goals
{
    List<Goal> goals = new List<Goal>();
    private int _totalScore;
    private string fileName = "goals2.txt";
    public Goals()
    { }
    public void DisplayGoals()
    {
        Console.WriteLine($"your Score:{_totalScore}");
        foreach (Goal i in goals)
        {
            Console.WriteLine(i);
        }
    }
    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }
    public void SumScore(bool isDone, int score)
    {
        foreach (Goal i in goals)
        {
            if (isDone)
            {
                _totalScore = _totalScore + score;
            }
        }
    }
    public void SaveGoals()
    {
        using StreamWriter outputFile = new StreamWriter(fileName);
        {

            foreach (Goal i in goals)
            {
                outputFile.WriteLine(i.ToFile());
            }
        }
    }
    public void LoadGoals()
    {
        string[] lines = File.ReadAllLines(fileName);
        foreach(string line in lines)
        {
            string[] items = line.Split("#");
            string goalType = items[0];
            if(goalType == "Simple")
            {
                string name = items[1];
                string discription = items[2];
                int points = int.Parse(items[3]);
                bool status = bool.Parse(items[4]);
                Simple simple = new Simple(name,discription,points, status);
                simple.SetGoalType(goalType);
                goals.Add(simple);
            }
        }
    }
public void RecordEvent()
{
    Console.WriteLine("which goal did you a compleat ");
}
}