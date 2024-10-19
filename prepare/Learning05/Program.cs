using System;

class Program
{
    static void Main(string[] args)
    {
        //create a base Assignment object
        Assignment a1 = new Assignment("Tenley Wheeler", "How to Create a Masterpiece");
        Console.WriteLine(a1.GetSummary());
        
        //create a new MathAssignment object
        MathAssignment math1 = new MathAssignment("Section 5.2", "Problems 1-5", "Danny Freidrich", "Multiplication");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeWorkList());

        //create new WritingAssignment object
        WritingAssignments writing1 = new WritingAssignments("Everybody Poops", "Mary Robbins", "Angie Hubbard", "The Digestive System");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());

    }
}