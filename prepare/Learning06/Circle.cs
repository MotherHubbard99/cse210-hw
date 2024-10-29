using System;
public class Circle:Shape
{
    private double _radius;
    public Circle(double radius):base()
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        //Circle Area=πr^2
        return Math.PI * Math.Pow(_radius, 2);
    }
}