class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;


    public string Name { get => _name; set => _name = value; }
    public string Id { get => _id; set => _id = value; }
    public double Price { get => _price; set => _price = value; }
    public int Quantity { get => _quantity; set => _quantity = value; }

    public Product (string name, string id, double price, int quantity)
    {
        Name = name;
        Id = id; 
        Price = price;
        Quantity = quantity;

    }

    public double GetPrice()
    {
        return Price * Quantity;
    }
}