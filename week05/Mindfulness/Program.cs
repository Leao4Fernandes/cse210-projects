using System;

class Program
{
    static void Main(string[] args)
    {
        string option = "";
        while (option != "4")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();
            Console.Clear();

            switch (option)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case "2":
                    Console.WriteLine("Coming soon!");
                    break;
                case "3":
                    Console.WriteLine("Coming soon!");
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}