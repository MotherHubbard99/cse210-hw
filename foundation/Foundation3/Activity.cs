using System;
public abstract class Activity
{
    protected int _lenMin;
    protected DateTime _date;
    public Activity(int lenMin, DateTime date)
    {
        _lenMin = lenMin;
        _date = date;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
 
    public string GetSummary()
    {
        return ($"{_date:dd MMM yyyy} {GetType().Name} ({_lenMin} min) - Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile ");
    }
}