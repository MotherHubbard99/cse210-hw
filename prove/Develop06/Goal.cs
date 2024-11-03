using System;
public abstract class Goal
{
    public string _shortName;
    public string _description;
    public int _points;

    //Read only access to private fields for the GoalManager class
    public string Description => _description;
    //public ShortName => _shortName;
    public int Points => _points;



    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;

    }
    public abstract void RecordEvent();
    public abstract Boolean IsComplete();
    public virtual string GetDetailsString()
    {
        return "";
    }
    public abstract string GetStringRepresentation();

}