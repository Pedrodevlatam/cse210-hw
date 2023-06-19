using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("This program helps you memorize scriptures by gradually hiding the words.");

        Console.WriteLine("\nChoose an option:");
        Console.WriteLine("1. Memorize a random scripture from the Book of Mormon");
        Console.WriteLine("2. Enter your own custom scripture");

        string input = Console.ReadLine();

        if (input == "1")
        {
            Scripture scripture = ScriptureGenerator.GenerateRandomScripture();
            RunScriptureMemorizer(scripture);
        }
        else if (input == "2")
        {
            Console.Write("Enter the scripture reference: ");
            string reference = Console.ReadLine();

            Console.Write("Enter the scripture text: ");
            string text = Console.ReadLine();

            Scripture scripture = new Scripture(reference, text);
            RunScriptureMemorizer(scripture);
        }
    }

    static void RunScriptureMemorizer(Scripture scripture)
    {
        Console.WriteLine("\nHere's your scripture:");
        Console.WriteLine(scripture.GetFormattedScripture());
        Console.WriteLine("Press Enter to hide some words or type 'quit' to exit.");

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "quit")
                break;

            scripture.HideRandomWords();

            Console.Clear();
            Console.WriteLine(scripture.GetFormattedScripture());
            Console.WriteLine("Press Enter to hide some words or type 'quit' to exit.");
        }
    }
}
