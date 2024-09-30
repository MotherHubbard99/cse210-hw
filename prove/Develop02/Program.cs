using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        String userChoice;
        Journal theJournal = new Journal();

        do
        {
            Console.WriteLine("Please select one of the following: ");
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Load ");
            Console.WriteLine("4. Save ");
            Console.WriteLine("5. Quit ");
            Console.Write("What would you like to do (1, 2, 3, 4 or 5)? ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")  //Write
            {
                //Get a random prompt question
                PromptGenerator myPrompt = new PromptGenerator();
                string randomPrompt = myPrompt.GetRandomPrompt(); 
                Entry anEntry = new Entry();
                //Go into the AddEntry method
                theJournal.AddEntry(anEntry, randomPrompt);
                
            }
            else if (userChoice == "2") //Display
            {
                theJournal.DisplayAll();
            }
            else if (userChoice == "3")  //Load
            {
                Console.WriteLine("What is the name of the existing file you would like to view? ");
                string fileName = Console.ReadLine();
                theJournal.LoadFromFile(fileName);
            }
            else if (userChoice == "4")  //Save
            {
                 Console.WriteLine("What name would you like to assign to this file? ");
                string fileName = Console.ReadLine();
                theJournal.SaveToFile(fileName);
            }
            else if (userChoice == "5")  //Quit
            {
                
            }
            else //not a valid number
            {
                Console.WriteLine("An invalid option was entered.  Please try again. ");
            }
        } while (userChoice != "5");


        Console.WriteLine("Thank you for using your Journal App and have a great day :) ");

    }
}