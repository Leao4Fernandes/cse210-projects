using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade? ");
        string grade = Console.ReadLine();

        int numGrade = int.Parse(grade);

        string letter = "";

        if (numGrade >= 90 )
        {
            letter = "A";
        }

        else if (numGrade >= 80 )
        {
            letter = "B";
        }

        else if (numGrade >= 70 )
        {
            letter = "C";
        }

        else if (numGrade >= 60 )
        {
            letter = "D";

        }

        else if (numGrade < 60 )
        {
            letter = "F";

        }

        else
        {
            Console.WriteLine("The grade is not a valid grade");
        }

        Console.WriteLine($"Your grade is {letter}");
    }
}