using System;
public class ListingActivity: Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity(int count, List<string> prompts): base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things( as you can in a certain area. ", 0)
    {
        _prompts = prompts;
        _count = count;
    }
    public void Run()
 
    {;
        DisplayStartingMessage();
        Console.WriteLine("List as many responses as you can to the following prompt: ");

        GetRandomPrompt();

        Console.Write("You may begin in: ");
        ShowCountDown(5);

        List<string> userList1 = new List<string>();
        GetListFromUser(userList1);

        DisplayEndingMessage();

    }
    public void GetRandomPrompt()
    {
         //Pick Random Question
        List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate? ",
            "What are personal strengths of yours? ",
            "Who are people that you have helped this week? ",
            "When have you felt the Holy Ghost this month? ",
            "Who are some of your personal heroes?"
        };

        //Create a Random instance
        Random random = new Random();

        //Generate a random index number
        int randomIndex = random.Next(_prompts.Count);

        //select a randon prompt
        string randomPrompt = _prompts[randomIndex];

        Console.WriteLine($"{randomPrompt}");
    }
    public List<string> GetListFromUser(List<string> userList1)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        do
        {
            Console.Write("> ");
            userList1.Add(Console.ReadLine());

        } while (DateTime.Now < endTime);
        Console.WriteLine($"You have listed {userList1.Count} items. ");

        return userList1;
    }
}