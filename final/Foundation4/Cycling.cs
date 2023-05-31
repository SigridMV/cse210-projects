class Cycling : Activity
{
    private double _speed;

    public double Speed { get => _speed; set => _speed = value; }

    public Cycling(DateTime _date, int _length, double _speed) : base(_date, _length)
    {
        Speed = _speed;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
      return 60 / Speed; 
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Speed: {Speed.ToString("0.0")} kph, Pace: {GetPace().ToString("0.0")} min per km";
    }
}