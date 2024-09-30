public class Entry()
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public void Display(Entry anEntry, string randomPrompt)
    {
     
        anEntry._promptText = ($"- Prompt: {randomPrompt}");
        Console.WriteLine(randomPrompt);
        Console.Write("> ");

        //Read in what the user input is 
        anEntry._entryText = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        //change the state to a string
        anEntry._date = ($"Date: {dateText}");
    
    }

}