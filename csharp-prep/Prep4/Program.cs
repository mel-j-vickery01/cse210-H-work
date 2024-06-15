using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a loisy of numbers, enter 0 when done.");
        List<int> numbers = new List<int>();
        int continueLoop = 0;
        while (continueLoop == 0)
        {
            Console.Write("Enter an Number: ");
            string inputNumber = Console.ReadLine();
            int number = int.Parse(inputNumber);
            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                continueLoop += 1;
            }



        }
        if (continueLoop == 1)
        {

            int sum = numbers.Sum();
            Console.WriteLine($"The Sum is: {sum}");
            double avg = sum / numbers.Count();
            Console.WriteLine($"The Average is: {avg}");
            int largest = numbers.Max();
            Console.WriteLine($"The largest number is: {largest}");
        }
    }
}