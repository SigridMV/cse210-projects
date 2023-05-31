class Swimming : Activity
{
    private int _laps;

    public int Laps { get => _laps; set => _laps = value; }

    public Swimming(DateTime _date, int _length, int _laps) : base(_date, _length)
    {
        Laps = _laps;
    }

    public override double GetDistance()
    {
       return Laps * 50 / 1000.0;
    }

    public override double GetPace()
    {
        return Length / GetDistance();
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Length) * 60;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Distance: {GetDistance().ToString("0.0")} km, Speed: {GetSpeed().ToString("0.0")} kph, Pace: {GetPace().ToString("0.0")} min per km";
    }


}