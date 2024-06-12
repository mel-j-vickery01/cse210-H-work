using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter you grade percentige: ");
        string percent_str = Console.ReadLine();
        int calc_int = int.Parse(percent_str);
        Console.Write("Your grade is ");
        if (calc_int >= 90)
        {
            Console.Write("A");
        }
        else if (calc_int >= 80)
        {
            Console.Write("B");
        }
        else if (calc_int >= 70)
        {
            Console.Write("C");
        }
        else if (calc_int >= 60)
        {
            Console.Write("D");
        }
        else
        {
            Console.Write("F");
        }

    }
}