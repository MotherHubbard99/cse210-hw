using System;

public class ReflectingActivity:Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity(List<string> prompts, List<string> questions):base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the powere you have and how you can use it in other aspects of your life. ", 0)
    {
 
        _prompts = prompts;
        _questions = questions;
    }
    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(3);
        string randomPrompt = GetRandomPrompt();
        DisplayPrompt(randomPrompt);
        string randomQuestions = GetRandomQuestion();
        Console.WriteLine("Now ponder each of the following questions as they are related to this experience");
        Console.Write($"You may begin in ");
        ShowCountDown(5);
        Console.Clear();
        DisplayQuestions(randomQuestions);
        ShowSpinner(5);
        randomQuestions = GetRandomQuestion();
        DisplayQuestions(randomQuestions);
        ShowSpinner(5);
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        //Pick Random Question
        List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else. ",
            "Think of a time when you did something really difficult. ",
            "Think of a time when you helped someone in need. ",
            "Think of a time when you did something truly selfless. ",
        };

        //Create a Random instance
        Random random = new Random();

        //Generate a random index number
        int randomIndex = random.Next(_prompts.Count);

        //select a randon prompt
        string randomPrompt = _prompts[randomIndex];

        return randomPrompt;
    }
    public string GetRandomQuestion()
    {
         //Pick Random Question
        List<string> _questions = new List<string>
        {
            "Why was this experiece meangingful to you? ",
            "Have you ever done anything like this before? ",
            "How did you get started? ",
            "How did you feel when it was complete? ",
            "WHat made this time different than other times when you were not as successful? ",
            "What is your favorite thing about this experience? ",
            "What could you learn from this experience that applies to other situations? ",
            "What did you learn about yourself through this experience? ",
            "How can you keep this experience in mind in the future? "
        };

        //Create a Random instance
        Random random = new Random();

        //Generate a random index number
        int randomIndex = random.Next(_questions.Count);

        //select a randon prompt
        string randomQuestions = _questions[randomIndex];

        return randomQuestions;
    }
    public void DisplayPrompt(string randomPrompt)
    {
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"--- {randomPrompt} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        //Stop the program until the user has pressed Enter
        Console.ReadLine();
    }
    public void DisplayQuestions(string randomQuestions)
    {
        Console.Write($"> {randomQuestions} ");
    }

}
