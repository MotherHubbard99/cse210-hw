using System;
using System.Runtime.InteropServices.Marshalling;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = "James";
        _chapter = 1;
        _verse = 5;

    }
    public Reference(string book, int chapter, int startVerse, int EndVerse)
    {

    }
    public string GetDisplayText()
    {
        return ($"{_book} {_chapter}:{_verse}");
    }

}