class Activity
{
    private DateTime _date;
    private int _length;

    public DateTime Date { get => _date; set => _date = value; }
    public int Length { get => _length; set => _length = value; }

    public Activity(DateTime _date, int _length)
    {
        Date = _date;
        Length = _length;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} - {GetType().Name} ({Length} min)";
    }
}