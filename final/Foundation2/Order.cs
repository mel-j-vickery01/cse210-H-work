class Order
{
    Customer _customer;
    List<Product> _products;
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void Add(Product product)
    {
        _products.Add(product);
    }
    public void Display()
    {
        Console.WriteLine($"{_customer}");
        foreach(Product i in _products)
        {
            i.Display();
        }
    }
}