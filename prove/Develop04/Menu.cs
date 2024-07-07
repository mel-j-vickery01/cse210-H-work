

class Menu
{
    public int DisplayMenu()
    {
        int input = 0;
        while (input < 1 || input > 4)
        {
            Console.Clear();
            Console.WriteLine("Ativities listed");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            // Console.WriteLine("3. Affermation Activity");
            Console.WriteLine("4. Quit program");
            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Input must be a valid intager seen on the list");
                Console.WriteLine("press enter to continue");
                Console.ReadLine();
            }
        }
        return input;

    }

}