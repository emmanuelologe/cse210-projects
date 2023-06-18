using System;
using System.Collections.Generic;


class Entry
{
    private List<String> Prompts;
    private Random random;
    private string dateText;
    private string question;
    private string answer;

    public Entry()
    {
        Prompts = new List<String>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is one thing i am thankful for from today?",
            "What is something new i learnt Today?",
        };
        random = new Random();
    }

    public Entry(string dateText, string question, string answer)
    {
        this.dateText = dateText;
        this.question = question;
        this.answer = answer;
    }

    public bool Menu(Journal journal)
    {
        Console.WriteLine("Please select one of the following options");
        Console.WriteLine("1. Write an entry to the journal");
        Console.WriteLine("2. save an entry to the journal");
        Console.WriteLine("3. display the journal entries");
        Console.WriteLine("4. load the entries in the journal");
        Console.WriteLine("5. Exit the journal Program");
        Console.Write("Enter a choice (Between 1-5): ");

        String Menuchoice = Console.ReadLine();
        Console.WriteLine();

        switch (Menuchoice)
        {
            case "1":
                EnterAnswer(journal);
                break;
            case "2":
                journal.SaveToFile();
                break;
            case "3":
                journal.DisplayEntries();
                break;
            case "4":
                journal.LoadEntriesInFile();
                break;
            case "5":
                return false;
            default:
                Console.WriteLine("Plese select again that was an invalid choice") ;
                break;                
        }
        return true;
    }
    private void EnterAnswer(Journal journal)
    {
        int randomIndex = random.Next(Prompts.Count);
        string question = Prompts[randomIndex];
        Console.WriteLine(question);

        Console.Write("> ");
        String answer = Console.ReadLine();

        DateTime CurrentDate = DateTime.Now;
        String dateText = CurrentDate.ToShortDateString();

        journal.AddEntry(question, answer, dateText);
    }
}


