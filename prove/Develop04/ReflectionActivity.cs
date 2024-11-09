class ReflectionActivity : Activity
{
  public ReflectionActivity()
  {
    this.InitMessage = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
  }

  private string GetRandomLine(string path)
  {
    List<string> lines = new List<string>(File.ReadAllLines(path));
    int index = new Random().Next(lines.Count);
    return lines[index];
  }

  public override void PerformActivity()
  {
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(this.Duration);
    Console.WriteLine(this.GetRandomLine("./reflection_prompts.txt"));
    bool continueReflecting = true;
    while (continueReflecting)
    {
      DateTime currentTime = DateTime.Now;
      double remainingSecs = (endTime - currentTime).TotalSeconds;
      Console.Write($"\t(Time remaining: {remainingSecs} seconds)\n\n");
      if (remainingSecs < 1)
      {
        Console.WriteLine("Not enough time for another reflection. Ending session.");
        Console.WriteLine($"Reflection session ended after {(currentTime - startTime).TotalSeconds} seconds.");
        continueReflecting = false;
        return;
      }
      util.DoWithDelay(
        () => Console.Write(
          this.GetRandomLine("./reflection_follow_ups.txt")
        ), 3
      );
      Console.Write("\n\n");
    }

  }
}