class Receptions : Event
{
    private string _rsvpEmail;

    public string RsvpEmail { get => _rsvpEmail; set => _rsvpEmail = value; }

    public Receptions(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        RsvpEmail = rsvpEmail;

    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nRSVP Email: {RsvpEmail}";
    }
}
