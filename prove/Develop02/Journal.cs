using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry anEntry, string randomPrompt)
    {
        // //initialize the _entries list
        // _entries = new List<Entry>();
        anEntry.Display(anEntry, randomPrompt);
        //Add the new anEntry to the _entries List
        _entries.Add(anEntry);

    }
    public void DisplayAll()
    {
        foreach (var anEntry in _entries)
        {
            System.Console.WriteLine($"{anEntry._date} {anEntry._promptText}");
            System.Console.WriteLine($"{anEntry._entryText}");
            Console.WriteLine();
        }
    }
    public void SaveToFile(string fileName)
    {
        // Don't forget to put using System.IO at the top, so C# knows where to find the StreamWriter class

        Console.WriteLine($"Saving to {fileName}");

        //save the file as the name user has input
        using (StreamWriter outputFile = new StreamWriter(fileName))
        //putting StreamWriter object in a using () blobk with make sure the file gets closed and clean up appropriately.
        {
            foreach (var anEntry in _entries)
            {
                outputFile.WriteLine($"{anEntry._date} {anEntry._promptText} {anEntry._entryText}");
            }
        }
    }
    public void LoadFromFile(string fileName)
    {
        /*The easiest way to read a text file in C# is to read the entire file into an array of strings (one per line) using the System.IO.File.ReadAllLines() function. Then, you can iterate through each string as you would with any list.
        */
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Console.WriteLine($"{line}");
            Console.WriteLine();
        }
    }

}