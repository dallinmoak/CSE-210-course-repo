
class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        this.InitMessage = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void PerformActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(this.Duration);
        bool continueBreathing = true;
        int breathInTime = 3;
        int breathOutTime = 3;
        while (continueBreathing)
        {
            DateTime currentTime = DateTime.Now;
            double remainingSecs = (endTime - currentTime).TotalSeconds;
            Console.Write($"Time remaining: {remainingSecs} seconds\n\n");
            if (remainingSecs < breathInTime + breathOutTime - 1)
            {
                Console.WriteLine("Not enough time for another round of breathing. Ending session.");
                Console.WriteLine($"Breathing session ended after {(currentTime - startTime).TotalSeconds} seconds.");
                continueBreathing = false;
                return;
            }
            util.DoWithDelay(() => Console.Write("Breathing in..."), breathInTime, util.PrintCountdown, 1);
            Console.Write("\n\n");
            util.DoWithDelay(() => Console.Write("Breathing out..."), breathOutTime);
            Console.Write("\n\n");
        }
    }
}
