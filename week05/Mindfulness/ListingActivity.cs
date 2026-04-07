using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people you appreciate?",
        "What are your strengths?",
        "Who have you helped recently?"
    };

    private Random _random = new Random();

    public ListingActivity() 
        : base("Listing Activity",
        "List as many positive things as you can.") { }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\n" + GetRandomPrompt());
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        List<string> items = new List<string>();

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }
}