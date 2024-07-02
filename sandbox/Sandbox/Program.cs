using System;
// using System.Runtime.InteropServices;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        Person person1 = new Person("keven", "yoter", 36, 472);


        FireMan fireman = new FireMan("EMT and para", "billy", "Betty", 28, 189);

        Console.WriteLine(person1.PersonInformation());
        Console.WriteLine(fireman.FiremanInformation());

    }
}

