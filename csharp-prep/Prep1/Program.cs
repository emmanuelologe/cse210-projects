using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.Write ("what is your first name?");
        string first_name = Console.ReadLine();
        Console.Write ("what is your last name?");
        string last_name = Console.ReadLine();
        Console.WriteLine ($"Your full name {last_name}, {first_name} {last_name}");
    }
}

