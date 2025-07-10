public class JournalEntry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string EntryText { get; set; }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Entry: {EntryText}\n");
    }
}