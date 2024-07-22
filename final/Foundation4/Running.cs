class Running : Activity
{
    private double _distance;
    public Running(string date, int lengthMinutes, double distance) : base(date, lengthMinutes)
    {
        _distance = distance;
    }
    public override void GetSummary()
    {
        base.GetSummary(_distance,);
    }

}