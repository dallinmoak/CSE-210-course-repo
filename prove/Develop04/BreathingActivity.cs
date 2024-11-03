
class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        this.InitMessage = "Welcome to the Breathing Activity!";
        // Constructor logic here
    }

    public override void PerformActivity()
    {
        for (int i = 0; i < this.Duration; i++)
        {
            this.DoWithDelay(() => Console.WriteLine("Breathing out..."), 3, this.PrintSpinner);
            this.DoWithDelay(() => Console.WriteLine("Breathing in..."), 3, this.PrintSpinner);
        }
    }
}
