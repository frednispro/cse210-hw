using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<JournalEntry> entries = new List<JournalEntry>();
    public List<string> prompts = new List<string>
    {
        "What made you smile today?",
        "What was the best part of your day?",
        "Did you learn something new today?",
        "What did you feel grateful for today?",
        "What is something you want to remember from today?"
    };

    public void AddEntry()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();

        JournalEntry entry = new JournalEntry(prompt, response);
        entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (JournalEntry entry in entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter file = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in entries)
            {
                file.WriteLine(entry.GetEntryText());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                JournalEntry entry = JournalEntry.FromText(line);
                entries.Add(entry);
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}