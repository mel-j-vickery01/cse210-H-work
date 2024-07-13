class Menu
{
    public int DisplayMenu()
    {
        int input;
        do
        {
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goal");
            Console.WriteLine("3. Save Goal");
            Console.WriteLine("4. Load Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("What is your Selection: ");
            return input = int.Parse(Console.ReadLine());
        } while (input != 6);
    }
    public int CreateActivityMenu()
    {
        int input;
        Console.WriteLine("What type of Goal do you want to set?");
        Console.WriteLine("1. Simple\n3. Eternal\n2. Check List");
        return input = int.Parse(Console.ReadLine());

    }
}