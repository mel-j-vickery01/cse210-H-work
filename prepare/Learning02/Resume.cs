using System;

public class Resume
{
public string _name = "Dwight";
 public List <Job> _jobs = new List<Job>();

public void Display()
{
    foreach (Job i in _jobs)
    {
        i.JobDisplay();
    }
}

}