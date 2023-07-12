using System;

public class Program
{
    private static void Main()
    {
        string reference = "John 3:16";
        string scriptureText = "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.";

        Scripture scripture = new Scripture(reference, scriptureText);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.ToString());

            Console.WriteLine("Press Enter to hide a random word or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                Console.WriteLine("The program has Ended!");
                break;
            }

            scripture.HideWords();
        }
    }
}
