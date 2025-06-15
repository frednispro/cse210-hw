using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine( "input your first name: ");
        string first_name = Console.ReadLine();
        Console.WriteLine("input your last name: ");
        string last_name = Console.ReadLine();
        Console.WriteLine($"your name is: {last_name}, {first_name} ");
    }
}