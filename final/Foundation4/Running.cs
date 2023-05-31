class Running : Activity
{

    private double _distance;

    public double Distance { get => _distance; set => _distance = value; }

    public Running(DateTime _date, int _length, double _distance) : base(_date, _length)
    {
        Distance = _distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetPace()
    {
        return Length / Distance;
    }

    public override double GetSpeed()
    {
        return (Distance / Length) * 60;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Distance: {Distance.ToString("0.0")} km, Speed: {GetSpeed().ToString("0.0")} kph, Pace: {GetPace().ToString("0.0")} min per km";
    }


}