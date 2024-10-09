using System;
using System.Runtime.CompilerServices;

public class Word
{
    private string _text;
    private bool _isHidden = false;

    public Word(string text)
    {
        _text = text;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {

    }
 
    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }

}