using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "UCI";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2026;
        job1._endYear = 2028;


        Job job2 = new Job();

        job2._company = "COFIDIS";
        job2._jobTitle = "Client Manager";
        job2._startYear = 2029;
        job2._endYear = 2038;

        job1.Display();
        job2.Display();

        Resume myResume = new Resume();

        myResume._name = "Leão";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}