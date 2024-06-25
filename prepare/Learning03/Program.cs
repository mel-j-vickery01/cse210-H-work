using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction con1 = new Fraction();
        

        int numerater = int.Parse(Console.ReadLine());
        Fraction con2 = new Fraction(numerater);
        
    }
}