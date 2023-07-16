public class ReflectionActivity : Activity
{
    private static readonly string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly string[] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection")
    {
    }

    protected override void ShowStartingMessage()
    {
        base.ShowStartingMessage();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine("Think deeply about the following prompt:");
        Console.WriteLine(_prompts[new Random().Next(0, _prompts.Length)]);
    }

    protected void PerformReflectionActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        TimeSpan interval = TimeSpan.FromSeconds(1);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(_questions[new Random().Next(0, _questions.Length)]);
            ShowSpinner(2);
            Console.WriteLine();
            Pause(1);

            if (DateTime.Now + interval > endTime)
                interval = endTime - DateTime.Now;

            if (interval > TimeSpan.Zero)
                Thread.Sleep(interval);
        }
    }

    protected override void PerformActivity()
    {
        PerformReflectionActivity();
    }
}