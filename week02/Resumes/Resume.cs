using System;

public class Resume
{
    //member variables or attributes
    public string _name;
    public List<Job> _jobs = new List<Job>();

    //the methods
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }

    } 
}
