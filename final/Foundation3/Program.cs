using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Salt Lake City", "UT", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Address address3 = new Address("789 Ocean Rd", "Miami", "FL", "USA");

        Event lecture = new Lecture("C# Basics", "Learn the fundamentals of C#", "June 15, 2025", "10:00 AM", address1, "John Smith", 50);
        Event reception = new Reception("Wedding Reception", "Celebrate with us!", "July 2, 2025", "6:00 PM", address2, "rsvp@wedding.com");
        Event outdoor = new OutdoorGathering("Beach Party", "Fun in the sun!", "August 10, 2025", "2:00 PM", address3, "Sunny, 85°F");

        List<Event> events = new List<Event>() { lecture, reception, outdoor };

        foreach (Event ev in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine("Full Details:");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine("Short Description:");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
        }
    }
}
