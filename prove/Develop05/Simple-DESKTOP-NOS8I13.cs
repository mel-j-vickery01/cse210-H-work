class Simple : Goal
{
    public Simple(string name, string discription, bool status) : base(name, discription, status)
    {}
    public override int AddScore()
    {
        int number = 35;
        Console.WriteLine("This is working");
        return number;
    }
}