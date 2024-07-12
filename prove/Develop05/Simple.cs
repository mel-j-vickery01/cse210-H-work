class Simple : Goal
{
    
    public Simple(string name, string discription, bool status) : base(name, discription, status)
    { }
    public Simple() :  base("","",false)
    {}
    public override void RunActivity()
    {
        SetName();
        SetDiscription();
        SetPoints();
        SetGoalType("Simple");
    }
}