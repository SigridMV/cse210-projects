class Address
{
    private string _street;  
    private string _city; 
    private string _country;

    public string Street { get => _street; set => _street = value; }
    public string City { get => _city; set => _city = value; }
    public string Country { get => _country; set => _country = value; }

    public Address(string street, string city, string country) 
    {
        Street = street; 
        City = city;
        Country = country;
    }

    public string GetAddress() 
    {
        return $"{Street}, {City}, {Country}";
    }
}