class Simple : Goal
{
    
    public Simple(string name, string discription, bool status) : base(name, discription, status)
    { }
    public override void RunActivity()
    {
        Console.Write("What is the name of your goal?: ");
        string name = Console.ReadLine();
        Console.Write("Write a short discription for your Goal: ");
        string discription = Console.ReadLine();
        Simple simp1 = new Simple(name, discription, false);
    }
    public override int RecordEvent()
    {
        throw new NotImplementedException();
    }
}