class Menu
{
    public void DisplayMenu()
    {
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goal");
        Console.WriteLine("3. Save Goal");
        Console.WriteLine("4. Load Goal");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("What is your Selection: ");
        int input = int.Parse(Console.ReadLine());

            Simple simp1 = new Simple("Simple", "this is a test", false);
        if(input == 1)
        {
            simp1.AddScore();
        }
        else
        {
            Console.WriteLine(simp1.AddScore());
        }
    }
    public void SubMenu()
    {
        Console.WriteLine("What type of Goal do you want to set?");
        Console.WriteLine("1. Simple\n2. Check List\n3. Eternal");
        int input = int.Parse(Console.ReadLine());
    }
}