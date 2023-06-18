using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal = new Journal();
        Entry entry = new Entry();

        bool shouldContinue = true;
        while (shouldContinue)
        {
            shouldContinue = entry.Menu(journal);
        }

        Console.WriteLine("Thank you for using the Program");

    }
}