namespace Abstraction_Demo;

public class Job
{
  public string _jobTitle;
  public string _company;
  public int _start_year;
  public int _end_year;
  
  public string DisplayJobDetails()
  {
    return $"{_jobTitle} ({_company}) {_start_year}-{_end_year}";
  }
  
}