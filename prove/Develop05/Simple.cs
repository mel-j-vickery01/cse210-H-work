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
        // Simple simp1 = new Simple(name, discription, false);
    }
    public override int RecordEvent()
    {
        throw new NotImplementedException();
    }
}