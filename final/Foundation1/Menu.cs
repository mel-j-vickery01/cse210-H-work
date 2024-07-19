class Menu
{
    public int DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("1. add video\n2. show videos\n3. Quit");
        return int.Parse(Console.ReadLine());
    }
}