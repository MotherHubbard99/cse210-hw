using System;
using System.IO;
public class SimpleGoal : Goal
{
    private Boolean _isComplete = false;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    public override void RecordEvent()
    {
        // Don't forget to put this at the top, so C# knows where to find the StreamWriter class
        //using System.IO; 
        Console.WriteLine("What is the filename you would like to save this to? ");

        string fileGoals = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileGoals))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");
            
            // You can use the $ and include variables just like with Console.WriteLine
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
        }
    }
    public override bool IsComplete()
    {
        _isComplete = IsComplete();
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}