using System;

class Program
{
    static void Main(string[] args)
    {
        Menu m = new Menu();
        Breathing Breath = new Breathing("Breathing", "This activity will help you relax through controlled breathing.\nDuring this activity it will ask you to breath in for 3 seconds, then hold for 3, and breath out for 4");
        Reflection reflection = new Reflection("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Listing listing = new Listing("#", "#");
        Affermation affermation = new Affermation("#", "#");
        int reponse = 0;
        while (reponse != 5)
        {
            reponse = m.DisplayMenu();


            if (reponse == 1)
            {
                Breath.RunActivity();
            }
            if (reponse == 2)
            {
                reflection.RunActivity();
            }
            if (reponse == 3)
            {
                affermation.test();
            }
            if (reponse == 4)
            {
                listing.test();
            }
        }
    }
}