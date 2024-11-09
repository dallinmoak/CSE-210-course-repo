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

	public abstract void PerformActivity();
}
