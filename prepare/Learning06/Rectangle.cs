using System;
using System.ComponentModel.DataAnnotations;

public class Rectangle:Shape
{
    private double _length;
    private  double _width;
    public Rectangle(double length, double width):base()
    {
        _length = length;
        _width = width;
    }
    public override double GetArea()
    {
        //reactangle area = length * Width
        return _length * _width;
    }
}