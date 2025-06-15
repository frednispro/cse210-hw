using System;

public class JournalEntry
{
    public string Date;
    public string Prompt;
    public string Response;

    public JournalEntry(string prompt, string response)
    {
        Date = DateTime.Now.ToShortDateString();
        Prompt = prompt;
        Response = response;
    }

    public void Display()
    {
        Console.WriteLine($"{Date} - {Prompt}");
        Console.WriteLine(Response);
        Console.WriteLine();
    }

    public string GetEntryText()
    {
        return $"{Date}|{Prompt}|{Response}";
    }

    public static JournalEntry FromText(string text)
    {
        string[] parts = text.Split('|');
        JournalEntry entry = new JournalEntry(parts[1], parts[2]);
        entry.Date = parts[0];
        return entry;
    }
}
