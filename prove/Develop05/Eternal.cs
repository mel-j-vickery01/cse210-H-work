class Eternal : Goal
{
    public Eternal(string name, string discription, bool status) : base(name, discription, status)
    { }
    public Eternal() : base("","",false)
    {}
    public override void RunActivity()
    {
        SetName();
        SetDiscription();
        SetPoints();
        SetGoalType("Eternal");
    }
}