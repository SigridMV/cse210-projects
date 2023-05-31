class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public string Title { get => _title; set => _title = value; }
    public string Description { get => _description; set => _description = value; }
    public DateTime Date { get => _date; set => _date = value; }
    public TimeSpan Time { get => _time; set => _time = value; }
    public Address Address { get => _address; set => _address = value; }

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time.ToString()}\nAddress: {Address.GetAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time.ToString()}\nAddress: {Address.GetAddress()}\nEvent type: {GetType().Name}";
    }

    public virtual string GetShortDescription()
    {
        return $"Event type: {GetType().Name}\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
    }
}