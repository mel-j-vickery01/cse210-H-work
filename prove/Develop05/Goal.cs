abstract class Goal
{
    private string _name;
    private string _discription;
    private bool _status;
    private int _points;
    private string _goalType;
    public Goal(string name, string discription, bool status)
    {
        _name = name;
        _discription = discription;
        _status = status;
        _points = 0;
    }
    public void SetName()
    {
        Console.Write("What is the name of your goal?: ");
        _name = Console.ReadLine();
    }
    public void SetDiscription()
    {
        Console.Write("Write a short discription for your Goal: ");
        _discription = Console.ReadLine();
    }
    public void SetPoints()
    {
        Console.Write("How many points is this worth?: ");
        _points = int.Parse(Console.ReadLine());
    }
    public void SetGoalType(string type)
    {
        _goalType = type;
    }
    public override string ToString()
    {
        return $"{_goalType} Goal, {_name}, {_discription}, worth {_points} points";
    }

    public abstract void RunActivity();
    public bool CheckDone()
    {
        if (_status)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}