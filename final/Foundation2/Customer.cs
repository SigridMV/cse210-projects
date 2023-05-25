class Customer
{
    private string _name;
    private Address _address;

    public string Name { get => _name; set => _name = value; }
    public Address Address { get => _address; set => _address = value; }

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public bool IsInUSA()
    {
        return Address.IsInUSA();
    }

    public double GetShippingCost()
    {
        if (IsInUSA())
        {
            return 5.0;
        }
        else
        {
            return 35.0;
        }
    }

    public string GetAddressString()
    {
        return Address.ToString();
    }
}