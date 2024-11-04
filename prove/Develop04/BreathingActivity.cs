
class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        this.InitMessage = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        // Constructor logic here
    }

    readonly Util util = Util.Instance;

    public override void PerformActivity()
    {
        DateTime StartTime = DateTime.Now;
        DateTime EndTime = StartTime.AddSeconds(this.Duration);
        bool continueBreathing = true;
        while (continueBreathing)
        {
            DateTime CurrentTime = DateTime.Now;
            if (CurrentTime >= EndTime)
            {
                Console.WriteLine($"Breathing session ended after {this.Duration} seconds.");
                continueBreathing = false;
                return;
            }
            util.DoWithDelay(() => Console.Write("Breathing in..."), 3, util.PrintCountdown, 1);
            Console.Write("\n\n");
            util.DoWithDelay(() => Console.Write("Breathing out..."), 3);
            Console.Write("\n\n");
        }
    }
}
