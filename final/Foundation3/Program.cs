using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("8035 mediteranion way", "Abandoned", "Texas");
        Address address2 = new Address("2400 lefthold ave", "Town", "Onterio");
        List<Event> events = new List<Event>();
        events.Add(new Lecture("company", "informational lecture to better unite teams", "5/26/12", "2:45", address2, "BoBurnhame", 500));
        Person person1 = new Person("Benny");
        Person person2 = new Person("Rosy");
        Person person3 = new Person("Sarah");
        Person person4 = new Person("Ben");
        Person person5 = new Person("Lexi");
        Person person6 = new Person("Carlos");
        Reception rec1 = new Reception("Wedding", "Bill & Margret", "7/12/24", "9:00", address1);
        rec1.AddPerson(person1);
        rec1.AddPerson(person2);
        rec1.AddPerson(person3);
        rec1.AddPerson(person4);
        rec1.AddPerson(person5);
        rec1.AddPerson(person6);
        events.Add(rec1);
        bool _roll = true;
        while (_roll == true)
        {
            int response = 0;
            Console.Clear();
            Console.WriteLine("1. List events\n2. Quit");
            response = int.Parse(Console.ReadLine());
            switch (response)
            {
                case 1:
                    foreach (Event e in events)
                    {
                        Console.Clear();
                        e.DisplayFull();
                        Console.Write("Press enter to Continue");
                        Console.ReadLine();
                    }
                    break;
                case 2:
                    _roll = false;
                    break;
            }
        }
    }
}