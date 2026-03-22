//Creativity: Instead of only hiding words with underscores, the program will 
//support a “Hint Mode” that shows the first letter of each word only.
//This helps users remember words more easily while practicing.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("Proverbs", 3, 5, 6);

        string text = "rust in the LORD with all your heart, and do not lean on your own understanding. In all your ways acknowledge him, and he will make straight your paths";

        Scripture scripture = new Scripture(reference, text);

        bool hintMode = false;

        while (true)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText(hintMode));

            if (scripture.IsCompletelyHidden())
                break;

            Console.WriteLine("\nOptions:");
            Console.WriteLine("Press Enter to continue");
            Console.WriteLine("Type 'hint' to toggle hint mode"); 
            Console.WriteLine("Type 'quit' to finish");

            Console.Write("> ");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
                break;

           
            else if (input == "hint")
            {
                hintMode = !hintMode;
                continue;
            }

            scripture.HideRandomWords(3);
        }
    }
}