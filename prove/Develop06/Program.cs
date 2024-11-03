using System;

public class Program
{
    static void Main(string[] args)
    {
        List<Goal> _goals = new List<Goal>();
       // Create an instance of GoalManager
        GoalManager goalManager = new GoalManager(_goals, 0);

        string userChoice = "";
        do
        {
            //Print the running amount of points
            goalManager.Start();

            //\t is used for indenting
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("\t1. Create New Goal ");
            Console.WriteLine("\t2. List Goals ");
            Console.WriteLine("\t3. Save Goals ");
            Console.WriteLine("\t4. Load Goals ");
            Console.WriteLine("\t5. Record Event ");
            Console.WriteLine("\t6. Quit ");
            Console.Write("Select a choice from the menu: ");

            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine("\t1. Simple Goal");
                Console.WriteLine("\t2. Eternal Goal ");
                Console.WriteLine("\t3. Checklist Goal ");
                Console.Write("Which type of Goal would you like to create? ");
                int goalType = int.Parse(Console.ReadLine());
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("what is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());
                if (goalType == 1)
                {
                    List<SimpleGoal> goals = new List<SimpleGoal>();
                    SimpleGoal simple1 = new SimpleGoal(name, description, points);
                    goalManager.CreateGoal(simple1, name, description,
                    points);

                }
                else if (goalType == 2)
                {
                   List<EternalGoal> goals = new List<EternalGoal>();
                   EternalGoal eternal1 = new EternalGoal(name, description, points);
                   goalManager.CreateGoal(eternal1, name, description, points);

                }
                else if (goalType == 3)
                {
                    Console.WriteLine("How mant fimes does this foal need to be accomplished for a bonus? ");
                    int target = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());
                    ChecklistGoal checklist1 = new ChecklistGoal(name, description, points, target, bonus);

                    

                }
                else
                {
                    Console.WriteLine("Your choice is not valid.  Please try again. ");
                    break;
                }



            }
            else if (userChoice == "2")
            {
                goalManager.DisplayPlayerInfo();
            }
            else if (userChoice == "3")
            {
                goalManager.SaveGoals();
            }
            else if (userChoice == "4")
            {

            }
            else if (userChoice == "5")
            {

            }
            else if (userChoice == "6")
            {
                Console.WriteLine("You have chosen to Quit. ");
                break;
            }

            

        } while (userChoice != "6");

        Console.WriteLine("Have a great day :)");

    }

    
}