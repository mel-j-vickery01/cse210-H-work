using System;

class Program
{
    static void Main(string[] args)
    {

        Fraction con1 = new Fraction();

        con1.DisplayFractionString();
        Console.WriteLine(con1.GetDecimalValue());


        Fraction con2 = new Fraction(5);
        con2.DisplayFractionString();
       Console.WriteLine(con2.GetDecimalValue());

        Fraction con3 = new Fraction(3,4);
        con3.DisplayFractionString();
        Console.WriteLine(con3.GetDecimalValue());

        Fraction con4 = new Fraction(1, 3);
        con4.DisplayFractionString();
        Console.WriteLine(con4.GetDecimalValue());

    }
}