using System;

namespace ScriptureMemorizer;

/*
 * EXCEEDING REQUIREMENTS:
 * 1. Scripture library: the program has a ScripturesLibrary class that stores
 *    several scriptures and picks one at random each time the program starts.
 *    The library has an AddScripture() method, so new scriptures can easily be
 *    added (for example, loaded from a file in the future) without changing
 *    the rest of the program.
 * 2. The library uses both Reference constructors (single verse and verse range).
 * 3. Each time the user presses Enter, a random number of words (1 to 4) is
 *    hidden instead of a fixed number, so each practice session feels different.
 * 4. The "quit" command is case-insensitive (quit, Quit, QUIT all work).
 */

class Program
{
    static void Main(string[] args)
    {
        ScripturesLibrary library = new ScripturesLibrary();
        Scripture scripture = library.GetRandomScripture();
        Random random = new Random();

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
            {
                break;
            }
            else
            {
                int numberToHide = random.Next(1, 5);
                scripture.HideRandomWords(numberToHide);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}