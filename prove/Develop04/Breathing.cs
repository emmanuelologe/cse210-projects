public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing")
    {
    }

    protected override void PerformActivity()
    {
         Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly.");
        Console.WriteLine("Clear your mind and focus on your breathing.");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        TimeSpan interval = TimeSpan.FromSeconds(2);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            Pause(3);
            Console.WriteLine("Breathe out...");
            Pause(3);

            if (DateTime.Now + interval > endTime)
                interval = endTime - DateTime.Now;

            if (interval > TimeSpan.Zero)
                Thread.Sleep(interval);
        }
    }
}