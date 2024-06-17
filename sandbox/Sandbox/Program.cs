using System;
// using System.Runtime.InteropServices;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        Circle myCircle = new Circle(10);
        Console.WriteLine($"{myCircle.GetArea()}");

        Circle unitCircle = new Circle(10);
        Console.WriteLine($"{unitCircle.GetDiametar()}");
        Console.WriteLine($"{unitCircle.GetRadius()}");
    }
}

