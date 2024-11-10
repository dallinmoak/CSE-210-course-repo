class ReflectionActivity : Activity
{
  public ReflectionActivity()
  {
    this.InitMessage = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    this.Interval_length = 3;
  }

  protected override void PreLoopAction()
  {
    Console.WriteLine(this.GetRandomLine("./reflection_prompts.txt"));
  }
  public override void PostLoopAction()
  {
  }
  public override void IntervalAction()
  {
    util.DoWithDelay(
      () => Console.Write(
        this.GetRandomLine("./reflection_follow_ups.txt")
      ), this.Interval_length
    );
    Console.Write("\n\n");
  }
}