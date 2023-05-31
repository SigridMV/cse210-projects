class Lectures : Event
{
    private string _speakerName;  
    private int _capacity;

    public string SpeakerName { get => _speakerName; set => _speakerName = value; }
    public int Capacity { get => _capacity; set => _capacity = value; }

    public Lectures(string title, string description, DateTime date, TimeSpan time, Address address, string speakerName, int capacity)
        : base(title, description, date, time, address)
    {
        SpeakerName = speakerName;
        Capacity = capacity;

    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nSpeaker: {SpeakerName}\nCapacity: {Capacity}";
    }
}