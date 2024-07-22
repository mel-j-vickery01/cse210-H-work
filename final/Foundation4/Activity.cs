abstract class Activity
{
    private string _date;
    private int _lengthMinutes;
    public Activity(string date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }
    public virtual int Pace(int time, int distance)
    {
        int pace = 0;
        return pace = time / distance;
    }
    public virtual int Speed(int distance, int pace)
    {
        int speed = 0;
        return speed = distance * pace;
    }
    public virtual int Distance(int time, int pace)
    {
        int distance = 0;
        return distance = pace * time;
    }
    public virtual void GetSummary()
    {
    }

}