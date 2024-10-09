using System;
using System.ComponentModel.Design.Serialization;
using System.Runtime.CompilerServices;

class Program
{
  
    static void Main(string[] args)
    {
        
        Reference theReference = new Reference("", 0, 0);
        
        string text = "If any of you lack wisdom, let him ask of God, that giveth to all men liberally and upbraideth not; and it shall be given him. ";
        //print the full scripture once
        Console.WriteLine(text);

        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");

        //initialize a string variable to hold user input
        string input = Console.ReadLine();

        while (true)
        {

            //start the while loop
            if (input.ToLower() == "exit")
            {
                break; 
            }
            //If Enter was pushed on the keyboard
            else if (input == "")
            {
                Scripture theScripture = new Scripture(theReference, text);
                //clear the console
                Console.Clear();

                Console.WriteLine(theReference.GetDisplayText());

                Console.WriteLine(theScripture.GetDisplayText());
                text = theScripture.GetDisplayText();

                Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
                input = Console.ReadLine();
            } 
            else{
                break;
            }
            
        }
        Console.WriteLine("Thank you for using Scripture Memorizer. ");
    }

}