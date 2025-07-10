public class Journal
{
    private List<JournalEntry> _entries = new List<JournalEntry>();

    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
    }

    public void ShowEntries()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }
}
