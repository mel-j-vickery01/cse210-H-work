using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int input = menu.DisplayMenu();
        if(input == 1)
        {
            int subinput = menu.CreateActivityMenu();
            if(subinput == 1)
            {
                
            }
        }
    }
}