
using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity", 
        "This activity will help you relax by guiding your breathing.") { }

    public void Run()
    {
        DisplayStartingMessage();

        int elapsed = 0;

        while (elapsed < _duration)
        {
            Console.WriteLine("\nBreathe in...");
            BreathingAnimation(3, true);

            Console.WriteLine("\nBreathe out...");
            BreathingAnimation(3, false);

            elapsed += 6;
        }

        DisplayEndingMessage();
    }

    private void BreathingAnimation(int seconds, bool inhale)
    {
        int steps = 10;
        double delay = (seconds * 1000.0) / steps;

        for (int i = 1; i <= steps; i++)
        {
          
            string visual = new string('*', inhale ? i : steps - i + 1);

            Console.Write("\r" + visual);

            Thread.Sleep((int)(delay + (i * 15)));
        }

        Console.Write("\r" + new string(' ', steps) + "\r"); // clear line
    }
}