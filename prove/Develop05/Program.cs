using System;

class Program
{

    static void Main(string[] args)
    {
        string userChoice = "";
        do
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                BreathingActivity breathe1 = new BreathingActivity();
                breathe1.Run();
            
            }
            else if (userChoice == "2")
            {
                List<string> prompts = new List<string>();
                List<string> questions = new List<string>();
                ReflectingActivity reflection1 = new ReflectingActivity(prompts, questions);
                reflection1.Run();
            }
            else if (userChoice == "3")
            {
                List<string> prompts = new List<string>();
                ListingActivity listing1 = new ListingActivity(0, prompts);
                listing1.Run();
            }
            else if (userChoice == "4")
            {
                Console.WriteLine("You have chosen Quit. ");
                break;
            }
            else
            {
                Console.WriteLine($"{userChoice} is not a valid choice, please try again.");
            }
        } while (userChoice != "4");

        Console.WriteLine("Have a great day :)");
    }
}