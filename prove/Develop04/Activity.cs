abstract class Activity
{
	public Activity()
	{

	}
	private string _initMessage;
	protected string InitMessage
	{
		set { this._initMessage = value; }
	}
	private int _duration;
	protected int Duration
	{
		get { return this._duration; }
	}
	private int _interval_length;

	protected int Interval_length
	{
		get { return this._interval_length; }
		set { this._interval_length = value; }
	}
	protected string GetRandomLine(string path)
	{
		List<string> lines = new List<string>(File.ReadAllLines(path));
		int index = new Random().Next(lines.Count);
		return lines[index];
	}
	protected static Util util = Util.Instance;
	public void Init()
	{
		Console.WriteLine(this._initMessage);
		this.GetDuration();
		this.PerformActivity();
		Console.WriteLine("Press any key to continue...");
		Console.ReadKey();
	}

	private void GetDuration()
	{
		Console.Write("How long, in seconds, would you like for your session? ");
		this._duration = int.Parse(Console.ReadLine());
	}

	protected abstract void PreLoopAction();
	public abstract void PostLoopAction();
	public abstract void IntervalAction();

	protected void PerformActivity()
	{
		DateTime startTime = DateTime.Now;
		DateTime endTime = startTime.AddSeconds(this.Duration);
		bool continueActivity = true;
		this.PreLoopAction();
		Console.Write(this._interval_length);
		while (continueActivity)
		{
			DateTime currentTime = DateTime.Now;
			double remainingSecs = (endTime - currentTime).TotalSeconds;
			Console.Write($"\t(Time remaining: {remainingSecs} seconds)\n\n");
			if (remainingSecs < this._interval_length - 1)
			{
				Console.WriteLine("Not enough time for another round. Ending session.");
				Console.WriteLine($"Activity session ended after {(currentTime - startTime).TotalSeconds} seconds.");
				continueActivity = false;
				this.PostLoopAction();
				return;
			}
			this.IntervalAction();
		}
	}
}
