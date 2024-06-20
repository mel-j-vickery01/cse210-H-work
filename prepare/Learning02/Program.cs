using System;

class Program
{
    static void Main(string[] args)
    {
        
        Job job1 = new Job();
        job1._jobTitle = "software Egg";
        job1._company = "macrosoft";
        job1._startYear = 2019;
        job1._endYear = 2021;
        

        Job job2 = new Job();
        job2._jobTitle = "Assistent to the reginal manager";
        job2._company = "Dunder mifflin paper company";
        job2._startYear = 2016;
        job2._endYear = 2019;
        

        Resume resume1 = new Resume();
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();

    }
}