class Simple : Goal
{
    public Simple(string name, string discription, bool status) : base(name, discription, status)
    {}
    public override void RunActivity()
    {
        Console.Write("BIIIG Win.\nLet's goooo");
    }
    public override int RecordEvent()
    {
        throw new NotImplementedException();
    }
}