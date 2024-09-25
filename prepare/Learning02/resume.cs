using System;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResumeInfo()
    {
        Console.WriteLine($"Name: {_name} ");
        Console.WriteLine($"Jobs: ");

        foreach (Job job in _jobs)
        {
            //Print each job
            job.DisplayJobDetails();
        }
    }
}

