using System;

class Program
{
    static void Main(string[] args)
    {
        Menu m = new Menu();
        Breathing Breath = new Breathing();
        Reflection reflection = new Reflection();
        Listing listing = new Listing();
        Affermation affermation = new Affermation();
        int reponse = 0;
        while (reponse != 5)
        {
            reponse = m.DisplayMenu();


            if (reponse == 1)
            {
                Breath.test();
                Breath.Spinner();
            }
            if (reponse == 2)
            {
                reflection.test();
                reflection.Spinner();
            }
            if (reponse == 3)
            {
                affermation.test();
                affermation.Spinner();
            }
            if (reponse == 4)
            {
                listing.test();
                listing.Spinner();
            }
        }
    }
}