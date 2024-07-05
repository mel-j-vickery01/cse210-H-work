class Affermation : Activity
{
    public Affermation(string title, string description) : base(title, description){}

    public void test()
    {
        Console.WriteLine("this is from Affermation class");
        Console.WriteLine("press enter to continue");
        Console.ReadLine();

    }

}