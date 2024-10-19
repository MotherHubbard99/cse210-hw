using System;
public class WritingAssignments:Assignment
{
    private string _title;
    private string _author;


    public WritingAssignments(string title, string author, string studentName, string topic):base(studentName, topic)
    {
        _title = title;
        _author = author;
    }
    public string GetWritingInformation()
    {
        return _title + " by " + _author;
    }
}