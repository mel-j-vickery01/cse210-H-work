class Menu
{
    public void DisplayMenu()
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
            input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("What type of Goal would you like to set?");
                Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. CheckList Goal");
                int subInput = int.Parse(Console.ReadLine());
                if (subInput == 1)
                {
                    Console.Write("What is the name of your goal?: ");
                    string name = Console.ReadLine();
                    Console.Write("Write a short discription for your Goal: ");
                    string discription = Console.ReadLine();
                    Simple simp1 = new Simple(name, discription, false);
                    simp1.RunActivity();
                }
                else if (subInput == 2)
                {

                }

            }
            else
            {

            }
        } while (input != 6);
    }
    public void SubMenu()
    {
        Console.WriteLine("What type of Goal do you want to set?");
        Console.WriteLine("1. Simple\n2. Check List\n3. Eternal");
        int input = int.Parse(Console.ReadLine());
    }
}