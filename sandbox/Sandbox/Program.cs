using System;
// using System.Runtime.InteropServices;


class Program
{
    static void Main(string[] args)
    {
        List <Employee> employees = new List<Employee>();

        Console.WriteLine("Hello Sandbox World!");

        // Employee employee = new Employee("Mark", 40, 25.15);

        // Console.WriteLine($"{employee.GetName()} is due: {employee.GetPay()}");

        ConstructionWorker constructionWorker = new ConstructionWorker("Martha", 40, 27.15);

        // Console.WriteLine($"{constructionWorker.GetName()} is due: {constructionWorker.GetPay()}");

        Doctor doc = new Doctor("Belinda", 250000);

        // Console.WriteLine($"{doc.GetName()} is due: {doc.GetPay()}");


        // employees.Add(employee);
        employees.Add(constructionWorker);
        employees.Add(doc);


        foreach (Employee e in employees)
        {
            Console.WriteLine($"{e.GetName()} is due: {e.GetPay()}. Insurance Cost: {e.InsuranceCost()}");
            Console.WriteLine(e.ToString());
        }
    }
}

