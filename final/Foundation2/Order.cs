class Order
{
    private List<Product> _products;
    private Customer _customer;

    public List<Product> Products { get => _products; set => _products = value; }
    public Customer Customer { get => _customer; set => _customer = value; }

    public Order(Customer customer)
    {
        Products = new List<Product>();
        Customer = customer;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in Products)
        {
            totalPrice += product.GetPrice();
        }
        totalPrice += Customer.GetShippingCost();


        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in Products)
        {
            packingLabel += "Product Name: " + product.Name + ", Product ID: " + product.Id + "\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return "Customer Name: " + Customer.Name + "\n" + Customer.GetAddressString();
    }
}