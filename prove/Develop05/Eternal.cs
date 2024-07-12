class Eternal : Goal
{
    public Eternal(string name, string discription, int points, bool status) : base(name, discription, points, status)
    { }
    public Eternal() : base("","", 0,false)
    {}
    public override void RunActivity()
    {
        SetName();
        SetDiscription();
        SetPoints();
        SetGoalType("Eternal");
    }
}