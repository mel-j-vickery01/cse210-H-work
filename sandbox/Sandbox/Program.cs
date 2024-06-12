using System;
// using System.Runtime.InteropServices;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
// int userAge = 0;

// while (userAge < 0 || userAge > 120)
// {
//     Console.Write("Please input your age (0-120): ");
//     userAge = int.Parse(Console.ReadLine());
// }

// int userAge2 = 0;
// do
// {
//     Console.Write("Please enter your age (0-120)");
//     userAge = int.Parse(Console.ReadLine());
// }while (userAge2 < 0 || userAge2 > 120);

// for(int i = -10000000; i < 1000000000; i += 10000)
// {
//     Console.WriteLine("" + i);
// }

// List<int> myNumbers = new List<int>();
// List<string> myNames = new List<string>();

// myNames.Add("Bob");
// myNames.Add("Mel");
// myNames.Add("Trevor");
// myNames.Add("Emily");
// myNames.Add("Noah");

// myNumbers.Add(42);
// myNumbers.Add(78);
// myNumbers.Add(68);
// myNumbers.Add(98);
// myNumbers.Add(20);

// foreach(string name in myNames)
// {
//     Console.WriteLine("" + name);
// }
// foreach(int number in myNumbers)
// {
//     Console.WriteLine("" + number);
// }
static double CalculateCircleArea(double radius)
    {
        double area = 0;
        area = Math.PI * radius * radius;
        return area;
    }
    double area = CalculateCircleArea(10);
    Console.Write(area);
}

