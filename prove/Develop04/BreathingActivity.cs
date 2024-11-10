
class BreathingActivity : Activity
{
	public BreathingActivity()
	{
		this.InitMessage = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
		this.Interval_length = 6;
		this._breathInTime = this.Interval_length / 2;
		this._breathOutTime = this.Interval_length / 2;
	}
	private int _breathInTime;
	private int _breathOutTime;
	static void Breathe(string dir)
	{
		Console.Write($"Breathing {dir}...");
	}
	protected override void PreLoopAction()
	{
	}
	public override void PostLoopAction()
	{
	}
	public override void IntervalAction()
	{
		util.DoWithDelay(
			() => Breathe("in"),
			_breathInTime,
			util.PrintCountdown,
			1
		);
		Console.Write("\n\n");
		util.DoWithDelay(
			() => Breathe("out"),
			_breathOutTime
		);
		Console.Write("\n\n");
	}
}
