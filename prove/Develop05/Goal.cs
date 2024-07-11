abstract class Goal
{
    string _name;
string _discription;
bool _status;
int _points;
string _goalType;
    public Goal(string name, string discription, bool status)
    {
        _name = name;
        _discription = discription;
        _status = status;
        _points = 0;
    }

    
    public abstract void RunActivity();
    public abstract int RecordEvent();

}