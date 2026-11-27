using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment writingAssignment = new WritingAssignment("John Doe", "English", "The Great Gatsby", "2024-06-15");
        Console.WriteLine(writingAssignment.GetWritingInformation());

        MathAssignment mathAssignment = new MathAssignment("Jane Smith", "Mathematics", "Chapter 5", "1-10");
        Console.WriteLine(mathAssignment.GetHomeworkList());
    }
}