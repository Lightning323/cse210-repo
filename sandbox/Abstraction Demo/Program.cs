using Abstraction_Demo;

Resume resume = new Resume();

var job = new Job();
job._jobTitle = "Software Engineer";
job._company = "Microsoft";
job._start_year = 2003;
job._end_year = 2012;
resume._jobs.Add(job);

var job2 = new Job();
job2._jobTitle = "Software Engineer";
job2._company = "Apple";
job2._start_year = 2013;
job2._end_year = 2022;
resume._jobs.Add(job2);

resume._name = "Bilbo Baggans";
Console.WriteLine(resume.DisplayJobDetails());