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
    public override string ToString()
    {
        return $"{_name}, {_discription}";
    }

    public abstract void RunActivity();
    public abstract int RecordEvent();

}