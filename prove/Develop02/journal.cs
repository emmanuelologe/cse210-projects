using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> entries;
    private string fileName;

    public Journal()
    {
        entries = new List<Entry>();
        fileName= "";
    }

    public void AddEntry(String dateText, string question, string answer)
    {
        Entry entry = new Entry(dateText, question, answer);
        
        entries.Add(entry);
    }

    public void SaveToFile()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries to save.");
            return;
        }

        Console.Write("Enter the file name to save your journal entries: ");
        string fileName = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Entry entry in entries)
                {
                    writer.WriteLine(entry.ToString());
                }
            }
            Console.WriteLine("Entries saved to the file.");
    }
    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        Console.WriteLine("My Journal Enteries: ");
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"{entry}");
        }
    }

    public void LoadEntriesInFile()
{
    Console.Write("Enter the file name to load the entries: ");
    string loadFileName = Console.ReadLine();
    Console.WriteLine();

    if (!File.Exists(loadFileName))
    {
        Console.WriteLine("File does not exist.");
        return;
    }

    try
    {
        entries.Clear();
        string[] lines = File.ReadAllLines(loadFileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(' ');
            if (parts.Length == 3)
            {
                string question = parts[0];
                string answer = parts[1];
                string dateText = parts[2];
                AddEntry(question, answer, dateText);
            }
        }
        Console.WriteLine("Entries loaded from the file.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error loading entries: {ex.Message}");
    }
}

}