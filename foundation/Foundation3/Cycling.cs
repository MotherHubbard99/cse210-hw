using System;
public class Cycling:Activity
{
    private int _speed;

    public Cycling(int speed, int lenMin, DateTime date) : base(lenMin, date)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return (_speed * _lenMin) / 60; 
    }
    public override double GetSpeed()
    {
        // Speed (mph or kph) = (distance / minutes) * 60
        return (GetDistance() / _lenMin) * 60;
    }
    public override double GetPace()
    {
        //Pace (min per mile or min per km)= minutes / distance
        return _lenMin / GetDistance();
    }
}