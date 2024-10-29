using System;
public class Square:Shape
{
    private double _side;
    public Square(double side):base()
    {
        _side = side;
    }
    public override double GetArea()
    {
        //Square area = side * side
        return _side * _side;
    }

}
