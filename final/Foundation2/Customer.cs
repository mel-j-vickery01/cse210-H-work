using System.Net.Sockets;

class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address adress)
    {
        _name = name;
        _address = adress;
    }
    public void Display()
    {
        Console.Write($"{_name}, ");
        _address.Display();
    }
}