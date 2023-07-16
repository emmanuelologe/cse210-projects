public class ListingActivity : Activity
{
    private static readonly string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing")
    {
    }

    protected override void ShowStartingMessage()
    {
        base.ShowStartingMessage();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine("Think about the following prompt and start listing items:");
        Console.WriteLine(_prompts[new Random().Next(0, _prompts.Length)]);
        Pause(3);
    }

    protected void PerformListingActivity()
    {
        Console.WriteLine("Start listing items:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        TimeSpan interval = TimeSpan.FromSeconds(10);

        int itemsCount = 0;

        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
                itemsCount++;

            if (DateTime.Now + interval > endTime)
                interval = endTime - DateTime.Now;

            if (interval > TimeSpan.Zero)
                Thread.Sleep(interval);
        }

        Console.WriteLine($"Number of items listed: {itemsCount}");
    }

    protected override void PerformActivity()
    {
        PerformListingActivity();
    }
}