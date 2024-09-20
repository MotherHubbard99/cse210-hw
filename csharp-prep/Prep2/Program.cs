using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage (using numbers only)? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);

        string letter = "";

        if (percentage >= 90)
        {
            // Console.WriteLine("Your grade is an A. ");
            letter = "A";
        }
        else if (percentage >= 80)
        {
            //Console.WriteLine("Your grade is a B. ");
            letter = "B";
        }
        else if (percentage >= 70)
        {
            //Console.WriteLine("Your grade is a C. ");
            letter = "C";
        }
        else if (percentage >= 60)
        {
            //Console.WriteLine("Your grade is a D. ");
            letter = "D";

        }
        else
        {
            // Console.WriteLine("Your grade is an F. ");
            letter = "F";

        }

        Console.WriteLine($"Your letter grade is a {letter}. ");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations on passing!");
        }
        else
        {
            Console.WriteLine("Unfortunately you did not passed, please try again. ");
        }
    }
}