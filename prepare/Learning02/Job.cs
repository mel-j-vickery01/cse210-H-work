using System;
public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    public Job()
    {}
    

    public void JobDisplay()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    } 




}
    // private void addJobTitle(string title)
    // {
    //     _jobTitle = ($"{title}");
    // }
    // private void addCompany(string company)
    // {
    //     _company=($"{company}");
    // }
    // private void addStartYear(int startYear)
    // {
    //     _startYear=(startYear);
    // }
    // private void addendYear(int endYear)
    // {
    //     _endYear=(endYear);
    // }
