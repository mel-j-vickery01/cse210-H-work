using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Goals goals = new Goals();
        int input = 0;
        while (input != 6)
        {
            input = menu.DisplayMenu();
            if (input == 1)
            {
                int subinput = menu.CreateActivityMenu();
                if (subinput == 1)
                {
                    Simple simple = new Simple();
                    simple.RunActivity();
                    goals.AddGoal(simple);
                }
            }
            else if (input == 2)
            {
                goals.DisplayGoals();
            }
        }
    }
}