using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("One by one, enter a list of numbers. Type 0 (zero) when finished. ");
        //declare variables that will be used
        int userNumber = -1;
        int sum = 0;
        int max = 0;

        //create a List holder for our numbers
        List<int> numbers = new List<int>();

        do
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                //compute the sum to be printed below
                sum = sum + userNumber;
                numbers.Add(userNumber);
            }

        } while (userNumber != 0);

        Console.WriteLine($"The sum is {sum}. ");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}. ");

        //find the highest number the user entered
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }

        }
        Console.WriteLine($"The largest number is {max}. ");

    }
}