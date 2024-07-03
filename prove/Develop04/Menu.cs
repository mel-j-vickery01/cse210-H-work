

class Menu
{
    private int input = 0;
    public void ShowMenu()
    {
        while (input != 5)
        {
            Console.WriteLine("1. Reflection Activity");
            Console.WriteLine("2. Breathing Exercise");
            Console.WriteLine("3. Affermation Exercise");
            Console.WriteLine("4. Listing Exercise");
            Console.WriteLine("5. Quit program");

            input = int.Parse(Console.ReadLine());
            


        }
    }

}