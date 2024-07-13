class CheckList : Goal
{
    private int _timesCompleted;
    private int _toDo;
    private int _bonuse;
    public CheckList(string name, string discription, int points, bool status, int timesCompleted) : base(name, discription, points, status)
    {
        _timesCompleted = timesCompleted;
    }
    public CheckList() : base(" ", " ", 0, false)
    { }
    public override void RunActivity()
    {
        SetName();
        SetDiscription();
        SetPoints();
        SetBonuse();
        SetToDo();
        SetGoalType("CheckList");
    }
    private void SetToDo()
    {
        Console.Write("How many times to get the bonuse");
        _toDo = int.Parse(Console.ReadLine());
    }
    private void SetBonuse()
    {
        Console.Write("Assign a bonuse: ");
        _bonuse = int.Parse(Console.ReadLine());
    }
    public override string ToString()
    {
        return $"{base.ToString()} times completed: {_timesCompleted} out of: {_toDo}";
    }
    public override string ToFile()
    {
        return $"{base.ToString()} times completed: {_timesCompleted} out of: {_toDo}";
    }

    public override int ReportEvent()
    {
        _timesCompleted += 1;
        if (_timesCompleted == _toDo)
        {
            Console.WriteLine($"You earned {_bonuse} Bonuse points!!!");
            MarkDone();
            return GetPoints() + _bonuse;
        }
        else
        {
            return GetPoints();
        }
    }
}




