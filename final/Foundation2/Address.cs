class Address
{

    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public string Street { get => _street; set => _street = value; }
    public string City { get => _city; set => _city = value; }
    public string State { get => _state; set => _state = value; }
    public string Country { get => _country; set => _country = value; }

    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    public bool IsInUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public override string ToString()
    {
        return $"Street: {_street}\n" +
               $"City: {_city}\n" +
               $"State: {_state}\n" +
               $"Country: {_country}";
    }

}