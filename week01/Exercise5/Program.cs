using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int favNum = PromptUserNumber();

        DisplayResult(userName,favNum);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            
            return userName;

        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string input = Console.ReadLine();
            int num = int.Parse(input);

            return num;
        }

        static int SquaredNumber(int num)
        {
            int SquNum = num * num;

            return SquNum;
        }

        static void DisplayResult(string name, int FavNumber)
        {
            Console.WriteLine($"Member {name}, the squared of your favorite number is {SquaredNumber(FavNumber)}");
        }

    }
}