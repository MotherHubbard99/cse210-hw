using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "BYU-Idaho";
        job1._jobTitle = "Student";
        job1._startYear = 2023;
        job1._endYear = 2025;
        //job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._company = "Stone & Company";
        job2._jobTitle = "Tax Preparer";
        job2._startYear = 2021;
        job2._endYear = 2025;
        //job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "Angie Hubbard";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResumeInfo();
    }
}