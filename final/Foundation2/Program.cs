using System;

class Program
{
    static void Main(string[] args)
    {
        Product pro1 = new Product("gold bar", "AU12", 250, 3);
        Product pro2 = new Product("sunglasses", "SN34", 6, 2);
        Address _address = new Address("2389 sundrive way", "SD", "CA", "USA");
        Customer customer = new Customer("Kevin mcalistar", _address);
        Order _order = new Order(customer);
        _order.Add(pro1);
        _order.Add(pro2);
        _order.Display();
        Console.ReadLine();
        customer.Display();
        Console.ReadLine();
        Console.WriteLine("Hello Foundation2 World!");
    }
}