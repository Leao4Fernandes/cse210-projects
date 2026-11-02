using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a list of numbers, type 0 when finished: ");
        string input = Console.ReadLine();
        List<int> numbers = new List<int>();

        while (input != "0")
        {
            int number = int.Parse(input);
            numbers.Add(number);
            Console.Write("Enter a list of numbers, type 0 when finished: ");
            input = Console.ReadLine();
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum of the numbers is: {sum}");

        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}");

        int largest = numbers[0];

        foreach(int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}