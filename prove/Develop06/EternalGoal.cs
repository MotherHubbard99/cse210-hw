using System;
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override bool IsComplete()
    {
        //an eternal goal is never complete
        return false;
    }
    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}