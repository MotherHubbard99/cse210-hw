using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
{
    public List<string> _prompts;
    public string randomPrompt;
    public string GetRandomPrompt()
    {
        //Pick Random Question
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today? ",
            "What was the best part of my day? ",
            "How did I see the hand of the Lord in my life today? ",
            "What was the strongest emotion I felt today? ",
            "If I had 1 thing I could do over today, what would it be? "
        };

        //used chat.gpt to help create the section below
        //Create a Random instance
        Random random = new Random();

        //Generate a random index number
        int randomIndex = random.Next(prompts.Count);

        //select a randon prompt
        randomPrompt = prompts[randomIndex];

        return randomPrompt;
    }
}