using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string percentage = Console.ReadLine();
        int number = int.Parse(percentage);

        if (number >= 90)
        {
            Console.WriteLine("Your Grade is A");
        }
        else if (number >= 80)
        {
            Console.WriteLine("Your Grade is B");
        }
        else if (number >= 70)
        {
            Console.WriteLine("Your Grade is C");
        }
        else if (number >= 60)
        {
            Console.WriteLine("Your Grade is D");
        }
        else if (number <= 60)
        {
            Console.Write("Your Grade is F");
        }

        if (number >= 70)
        {
            Console.Write("Congratulations you have passed!");
        }
        else
        {
            Console.Write("You can do better, You did not pass.");
        }
    }
}