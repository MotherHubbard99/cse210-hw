using System;

public abstract class Shape
{
    private string _color;
    public Shape()
    {
        //_color = color;
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    //virtual makes this eligible to be overriden in the derived classes
    // public virtual double GetArea()
    // {
    //     return 0;
    // }
    public abstract double GetArea();

}