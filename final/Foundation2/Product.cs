class Product
{
    private string _name;
    private string _ID;
    private int _pricePerUnit;
    private int _quantity;
    private int _itemCost;
    public Product(string name, string ID, int unitPrice, int quantity)
    {
        _name = name;
        _ID = ID;
        _pricePerUnit = unitPrice;
        _quantity = quantity;
        ItemCost(_pricePerUnit, _quantity);
    }
    private void ItemCost(int unit, int quantity)
    {
        _itemCost = unit * quantity;
    }

    public void Display()
    {
        Console.WriteLine($"{_name}: {_ID} ${_pricePerUnit} * {_quantity}: ${_itemCost}");
    }
}