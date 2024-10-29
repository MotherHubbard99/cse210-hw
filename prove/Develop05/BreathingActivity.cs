using System;

public class BreathingActivity: Activity
{
    public BreathingActivity():base("Breathing Activity.", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0)
    {
        
    }
    public void Run()
    {
        DisplayStartingMessage();
        // Console.Write("How long, in seconds, would you like for your session? ");
        // int duration = int.Parse(Console.ReadLine());
        // Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        for (int i = _duration; i > 0;)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine("Breathe Out...");
            ShowCountDown(4);
            i = i - 8;
        }
        Console.WriteLine("Well Done!!");
        ShowSpinner(5);
        DisplayEndingMessage();
        ShowSpinner(5);
    }
}