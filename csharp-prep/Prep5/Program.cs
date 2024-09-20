using System;
using System.Diagnostics;
using System.Reflection.Metadata;

class Program
{

    static void Main(string[] args)
    {
        string welcome = DisplayWelcome();
        Console.WriteLine(welcome);

        string user = PromptUserName();

        int favNum = PromptUserNumber();

        float sqRoot = SquareNumber(favNum);

        DisplayResult(user, sqRoot);

        //Welcome message
        static string DisplayWelcome()
        {
            string welcome = "Welcome to the Program! ";
            return welcome;
        }
        //Asks for and returns the user name
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favNum = int.Parse(Console.ReadLine());
            return favNum;
        }

        static float SquareNumber(int favNum)
        {
            int sqRoot = favNum * favNum;
            return sqRoot;
        }

        static void DisplayResult(string user, float sqRoot)
        {
            Console.WriteLine($"{user}, the square of your number is {sqRoot}.");
        }
    }
}