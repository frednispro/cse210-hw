using System;
using System.Collections.Generic;

class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you helped someone.",
        "Think of a time when you were brave.",
        "Think of a time when you did something hard."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was it meaningful?",
        "How did you feel after?",
        "What did you learn?",
        "Would you do it again?"
    };

    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity helps you think about moments of strength and growth.";
    }

    protected override void DoActivity()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine("Prompt: " + prompt);
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.Write("> " + question);
            ShowSpinner(5);
        }
    }
}
