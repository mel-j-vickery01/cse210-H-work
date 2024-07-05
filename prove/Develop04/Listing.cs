
class Listing : Activity
{
    public Listing(string title, string description) : base(title, description){}

    public void test()
    {
        Console.WriteLine("this is from Listing class");
        Console.WriteLine("press enter to continue");
        Console.ReadLine();

    }

}