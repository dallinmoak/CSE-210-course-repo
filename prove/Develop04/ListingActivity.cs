class ListingActivity : Activity
{
  public ListingActivity()
  {
    this.InitMessage = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    this.Interval_length = 0;
  }
  private int _listCount = 0;
  protected override void PreLoopAction()
  {
    Console.WriteLine(this.GetRandomLine("./listing_prompts.txt"));
    Console.WriteLine("list as many responses as you can, separated by newlines");
  }
  public override void PostLoopAction()
  {
    Console.WriteLine($"You listed {_listCount} items.");
  }
  public override void IntervalAction()
  {
    string response = Console.ReadLine();
    if (response != "") _listCount++;
  }
}