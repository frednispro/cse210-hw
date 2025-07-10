class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string option = "";

        while (option != "3")
        {
            Console.WriteLine("\n1. Write Entry\n2. View Journal\n3. Exit");
            Console.Write("Choose an option: ");
            option = Console.ReadLine();

            if (option == "1")
            {
                Console.Write("Enter today's prompt: ");
                string prompt = Console.ReadLine();

                Console.Write("Write your response: ");
                string response = Console.ReadLine();

                JournalEntry entry = new JournalEntry
                {
                    Date = DateTime.Now.ToShortDateString(),
                    Prompt = prompt,
                    EntryText = response
                };

                journal.AddEntry(entry);
            }
            else if (option == "2")
            {
                journal.ShowEntries();
            }
        }

        Console.WriteLine("Goodbye!");
    }
}