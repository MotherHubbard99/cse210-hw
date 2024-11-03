using System;
//need to add this to create a .txt file
using System.IO;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score = 0;
    private string _name;
    private string _description;
    private int _points;

    public GoalManager(List<Goal> goals,  int score)
    {
        _goals = goals;
        _score = score;
    }
    public void Start()
    {
        int totalPoints = 0;

        if (_goals.Any())
        {
            foreach (var goal in _goals)
            {
                totalPoints =+ _points;
            }
        }
        if (totalPoints > 0)
        {
            Console.WriteLine($"You have {totalPoints} points. ");
        }
        else
        {
            Console.WriteLine("You have 0 points. ");
        }
    }
    public void DisplayPlayerInfo()
    {
        if (_goals.Any())
        {
            Console.WriteLine("The goals are: ");
            //initialize the printing count
            int i = 1;
            foreach (var goal in _goals)
            {
                string complete = "";
                // if IsComplete
                // {
                    complete = "[ ]";
                // }
                // else
                // complete = "[X]";

                Console.WriteLine($"{i} {complete} Name: {(_name)}, ({_description})");
                
                //increment by 1 each time
                i++;
            }
        }
        else
        {
            Console.WriteLine("The list is empty. ");
        }
        
    }
    public void ListGoalNames(string name)
    {
        
    }
    public void ListGoalDetails()
    {

    }
    public void CreateGoal(Goal goal, string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _goals.Add(goal);
    }
    public void RecordEvent()
    {

    }
    public void SaveGoals()
    {
        Console.WriteLine("What is the filename you would like to save your goal(s) to? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            //Add total points here

        }
    }
    public void LoadGoals()
    {
        
    }
}