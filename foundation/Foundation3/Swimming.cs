using System;
public class Swimming : Activity
{
    private int _laps;
  
    public Swimming(int laps, int lenMin, DateTime date) : base(lenMin, date)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        //Distance (miles) = swimming laps * 50 meters / 1000 * 0.62
        return (_laps * 50 / 1000) * 0.62;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / _lenMin) * 60;
    }
    public override double GetPace()
    {
        return _lenMin / GetDistance();
    }
}
