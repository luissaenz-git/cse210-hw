using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        // Create object Job
        Job job1 = new Job();
        // Set the attributes of the job1 object
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Create another object Job
        Job job2 = new Job();
        // Set the attributes of the job2 object
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume newResume = new Resume();

        newResume._name = "Allison Rose";

        //Add declared objetcts jobs to the object type Resume that includes a list of jobs
        newResume._jobs.Add(job1);
        newResume._jobs.Add(job2);



        newResume.Display();
        
        
    
    }
}