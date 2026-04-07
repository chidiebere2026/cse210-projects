using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you stood up for someone.",
        "Think of a time you did something difficult.",
        "Think of a time you helped someone."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn?",
        "What made it different?"
    };

    private Random _random = new Random();

    public ReflectingActivity() 
        : base("Reflection Activity",
        "Reflect on times you showed strength.") { }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\n" + GetRandomPrompt());
        Console.WriteLine("\nThink about it...");
        ShowSpinner(5);

        int elapsed = 0;

        while (elapsed < _duration)
        {
            Console.WriteLine("\n" + GetRandomQuestion());
            ShowSpinner(4);
            elapsed += 4;
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        return _questions[_random.Next(_questions.Count)];
    }
}