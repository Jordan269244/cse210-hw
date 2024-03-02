using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Google";
        job1._startYear = 1998;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._jobTitle = "Computer Scientist";
        job2._company = "Microsoft";
        job2._startYear = 2004;
        job2._endYear = 2023;
        
        job1.Display();
        job2.Display();


        Resume myResume = new Resume();
        myResume._name = "Jordan Wilson";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }

    

        
}