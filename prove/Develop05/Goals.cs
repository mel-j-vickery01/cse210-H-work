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
                outputFile.Write(i.ToString());
            }
        }
    }
public void RecordEvent()
{
    Console.WriteLine("which goal did you a compleat ");
}
}