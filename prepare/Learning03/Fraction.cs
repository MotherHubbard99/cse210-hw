using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    //constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //Methods
    public string GetFractionString()
    {
        //temp variable that is recomputed each time this is called
        string text = $"{_top}/{_bottom}";
        return text;
    }
    public double GetDecimalValue()
    {
        //temp variable that is recomputed each time this is called
        return (double)_top / (double)_bottom;
    }

}