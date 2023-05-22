using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Web designer";
        job1._company = "SiteCliq";
        job1._startYear = 2023;
        job1._endYear   =2028;

        Job job2 = new Job();
        job2._jobTitle = "CEO";
        job2._company = "My Billion Dollaars Company";
        job2._startYear = 2028;
        job2._endYear = 3000;


        Resume myResume = new Resume();
        myResume._name = "Emmanuel";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);


        myResume.Display();
    }
}