using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("Please enter a magic number from 1 to 100: ");
        //int magicNumber = int.Parse(Console.ReadLine());
        //Have the computer pull a random number from 1 to 100
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        //declare and initialize userGuess
        int userGuess = -1;

        while (userGuess != magicNumber)
        {
            //user guess
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess == magicNumber)
            {
                Console.WriteLine("Congratulations, you guessed it! ");
            }
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Please guess lower. ");
            }
            else
            {
                Console.WriteLine("Please guess higher. ");
            }
        }
    }
}