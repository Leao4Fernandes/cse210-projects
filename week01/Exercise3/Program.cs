using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string input1 = Console.ReadLine();
        int magicNum = int.Parse(input1);

        Console.Write("What is your guess? ");
        string input2 = Console.ReadLine();
        int guess = int.Parse(input2);


        while (guess != magicNum)
        {
            if (guess < magicNum)
            {
                Console.WriteLine("Higher");
                string input3 = Console.ReadLine();
                int guess1 = int.Parse(input3);
                guess = guess1;
            }
            else if (guess > magicNum)
            {
                Console.WriteLine("Lower");
                string input4 = Console.ReadLine();
                int guess2 = int.Parse(input4);
                guess = guess2;
            }
        }
        Console.WriteLine("You guessed it!");
    }
}