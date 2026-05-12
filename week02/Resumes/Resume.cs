using System;

public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    public Resume()
    {
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        //for each job of the type job in the list of jobs, print the job information
        foreach (Job listedJob in _jobs)
        {
            // calls each job's display method to print the job information
            // due to the fact that the job class 
            // has a display method that formats the output of the job information
            listedJob.Display();
        }
    }
}