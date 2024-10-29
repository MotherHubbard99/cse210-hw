using System;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"{_description}");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get Ready...");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done! ");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");

        // foreach (string s in animationStrings)
        // {
        //     Console.Write(s);
        //     Thread.Sleep(1000);
        //     //\b is backspace, so backspace, space, backspace
        //     Console.Write("\b \b");
        // }

        //Have the spinner run for so many int seconds
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i ++;
            //If you get to the end of the list and still have time, then reset it to zero
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        // -- makes it count down by one
        for (int i=seconds; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            //\b is backspace, so backspace, space, backspace
            Console.Write("\b \b");
        }
    }
}