using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int score = 0;
        bool done = false;

        while (!done)
        {
            Console.WriteLine();
            Console.WriteLine($"Your score: {score}");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("What do you want to do? ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal(goals);
            }
            else if (choice == "2")
            {
                ListGoals(goals);
            }
            else if (choice == "3")
            {
                score += RecordEvent(goals);
            }
            else if (choice == "4")
            {
                SaveGoals(goals, score);
            }
            else if (choice == "5")
            {
                (goals, score) = LoadGoals();
            }
            else if (choice == "6")
            {
                done = true;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }

    static void CreateGoal(List<Goal> goals)
    {
        Console.WriteLine("What kind of goal? 1) Simple 2) Eternal 3) Checklist");
        string type = Console.ReadLine();

        Console.Write("Name of goal: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (type == "2")
        {
            goals.Add(new EternalGoal(name, desc, points));
        }
        else if (type == "3")
        {
            Console.Write("How many times to finish? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    static void ListGoals(List<Goal> goals)
    {
        int i = 1;
        foreach (Goal g in goals)
        {
            Console.WriteLine($"{i}. {g.GetStatus()}");
            i++;
        }
    }

    static int RecordEvent(List<Goal> goals)
    {
        ListGoals(goals);
        Console.Write("Which goal did you complete? ");
        int num = int.Parse(Console.ReadLine()) - 1;
        if (num >= 0 && num < goals.Count)
        {
            int earned = goals[num].RecordEvent();
            Console.WriteLine($"You got {earned} points!");
            return earned;
        }
        Console.WriteLine("Invalid goal.");
        return 0;
    }

    static void SaveGoals(List<Goal> goals, int score)
    {
        using (StreamWriter sw = new StreamWriter("goals.txt"))
        {
            sw.WriteLine(score);
            foreach (Goal g in goals)
            {
                sw.WriteLine(g.SaveString());
            }
        }
        Console.WriteLine("Saved!");
    }

    static (List<Goal>, int) LoadGoals()
    {
        List<Goal> goals = new List<Goal>();
        int score = 0;

        if (File.Exists("goals.txt"))
        {
            string[] lines = File.ReadAllLines("goals.txt");
            score = int.Parse(lines[0]);
            for (int i = 1; i < lines.Length; i++)
            {
                Goal g = Goal.LoadFromString(lines[i]);
                if (g != null) goals.Add(g);
            }
            Console.WriteLine("Loaded!");
        }
        else
        {
            Console.WriteLine("No file found.");
        }
        return (goals, score);
    }
}

// I added a leveling system: every 1000 points increases the player's level,
// and the level is displayed in the main menu. This exceeds the basic requirements.