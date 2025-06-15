using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Exodus", 15, 2), "The Lord is my strength and my song; he has given me victory."),
            new Scripture(new Reference("Exodus", 14, 14), "The Lord will fight for you; you need only to be still."),
            new Scripture(new Reference("Revelation", 14, 13), "Blessed are the dead who die in the Lord from now on."),
            new Scripture(new Reference("Mark", 8, 36), "What good is it for someone to gain the whole world, yet forfeit their soul?"),
            new Scripture(new Reference("Galatians", 4, 7), "So you are no longer a slave, but God’s child; and since you are his child, God has made you also an heir."),
            new Scripture(new Reference("Romans", 8, 30), "And those he predestined, he also called; those he called, he also justified; those he justified, he also glorified."),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.")
        };

        Random random = new Random();

        foreach (Scripture scripture in scriptures)
        {
            while (!scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
                string input = Console.ReadLine();
                if (input.Trim().ToLower() == "quit")
                    return;
                scripture.HideRandomWords(random, 3);
            }
        }

        Console.Clear();
        Console.WriteLine("All scriptures are hidden. Good job memorizing!");
    }
}
