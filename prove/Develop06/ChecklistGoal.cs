using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus):base(name, description, points)
    {
        _bonus = bonus;
        _target = target;
    }
    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}