class OutdoorGatherings : Event
{
    private string _weatherForecast;

    public string WeatherForecast { get => _weatherForecast; set => _weatherForecast = value; }

    public OutdoorGatherings(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        WeatherForecast = weatherForecast;

    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nWeather Forecast: {WeatherForecast}";
    }
}