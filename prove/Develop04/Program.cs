using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program Menu");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BreathingActivity breath = new BreathingActivity();
                breath.Run();
            }
            else if (choice == 2)
            {
                ReflectionActivity reflect = new ReflectionActivity();
                reflect.Run();
            }
            else if (choice == 3)
            {
                ListingActivity list = new ListingActivity();
                list.Run();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Thanks for being mindful today!");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}


// Uses class design with inheritance and encapsulation.
// Listing Activity counts items and Reflection shows random questions.

