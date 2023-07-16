using System;
using System.Threading;

public class Activity
{
    protected int _duration;
    protected string _name;

    protected Activity(string name)
    {
        _name = name;
    }

    public void Start()
    {
        ShowStartingMessage();
        Pause(3);
        PerformActivity();
        ShowFinishingMessage();
        Pause(3);
    }

    protected virtual void ShowStartingMessage()
    {
        Console.WriteLine($"--- {_name} Activity ---");
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
    }

    protected virtual void ShowFinishingMessage()
    {
        Console.WriteLine("Great job! You have completed the activity.");
        Console.WriteLine($"Activity: {_name}");
        Console.WriteLine($"Duration: {_duration} seconds");
    }

    protected void Pause(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b|");
            Thread.Sleep(250);
        }
        Console.Write("\b");
    }

    protected virtual void PerformActivity()
    {
        // Default implementation of PerformActivity in the base class
    }
}
