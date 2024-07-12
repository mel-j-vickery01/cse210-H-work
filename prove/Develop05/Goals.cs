class Goals
{
    List<Goal> goals = new List<Goal>();
    int _totalScore = 0;
    int _score;
    public Goals()
    {
        _score = 0;
    }
    public void DisplayGoals()
    {
        foreach (Goal i in goals)
        {
            Console.WriteLine(i);
        }
    }
    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

}