using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        
        Random random = new Random();
        
        string textFile = "textFile.txt";

        List<string> prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "What is something I learned today?",
            "What is something I could have done better today?",
            "What am I grateful for today?"
        };

        Journal journal = new Journal();


        int userInput = 0;
        while (userInput != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();


                    int index = random.Next(prompts.Count);
                    string promptText = prompts[index];

                    Entry entry = new Entry();

                    Console.WriteLine(promptText);
                    string write = Console.ReadLine();
                    entry._date = dateText;
                    entry._promptText = promptText;
                    entry._entryText = write;

                    journal.AddEntry(entry);

                    break;

                case 2:

                    journal.DisplayAll();

                    break;

                case 3:

                    journal.LoadFromFile(textFile);

                    break;

                case 4:

                    journal.SaveToFile(textFile);

                    break;

                case 5:
                    userInput = 5;
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

        }
    }
}