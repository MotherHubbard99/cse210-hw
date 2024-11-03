using System;
public class Running : Activity
{
    //distance in miles
    private double _distance;
   
    public Running(double distance, int lenMin, DateTime date) : base(lenMin, date)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        //speed in mph
        return (_distance / _lenMin) * 60;
    }
    public override double GetPace()
    {
        //minutes per mile
        return _lenMin / _distance ;
    }
    
    //Console.WriteLine($"{GetSummary()}");
    
}