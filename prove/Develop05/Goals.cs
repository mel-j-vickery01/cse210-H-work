class Goals
{
    List<Goal> goals = new List<Goal>();
    int _totalScore = 0;
    int _score;
    public Goals(Goal goal, int score)
    {
        goals.Add(goal);
        _score = score;
    }
    public void DisplayGoals()
    {
        foreach(Goal i in goals)
        {
            Console.WriteLine(i);
        }
    }
}