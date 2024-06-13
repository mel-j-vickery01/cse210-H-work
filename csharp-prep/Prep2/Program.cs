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
        string letterGrade = "";
        if (calc_int >= 90)
        {
            letterGrade += "A";
        }
        else if (calc_int >= 80)
        {
            letterGrade += "B";
        }
        else if (calc_int >= 70)
        {
            letterGrade += "C";
        }
        else if (calc_int >= 60)
        {
            letterGrade += "D";
        }
        else
        {
            letterGrade += "F";
        }
            Console.WriteLine(letterGrade);

        if (calc_int >= 70)
        { 
        Console.WriteLine("Good Job! You've passed! pretty cool bro B)");
        }
        else
        {
            Console.Write("Dang man, not this time, but effort never failes. Prayer can help focuse your mind! Stay awesome B)");
        }


    }
}