using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "List people you appreciate:",
        "List things you're good at:",
        "List moments you felt peace:"
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity helps you think about the good things in your life.";
    }

    protected override void DoActivity()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine("Prompt: " + prompt);
        Console.Write("You may begin in: ");
        ShowCountdown(3);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }

        Console.WriteLine($"You listed {items.Count} items!");
    }
}
