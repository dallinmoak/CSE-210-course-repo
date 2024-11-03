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
    public void Init()
    {
        Console.WriteLine(this._initMessage);
        this.GetDuration();
        this.PerformActivity();
    }

    private void GetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        this._duration = int.Parse(Console.ReadLine());
    }

    public void DoWithDelay(Action f, int secs, Action<int> waitAction)
    {
        int interval = 3;
        for (int i = 0; i < interval * secs; i++)
        {
            waitAction(i);
            Thread.Sleep((int)Math.Round(1000.0 / interval));
        }
        Console.WriteLine();
        f();
    }

    public void PrintSpinner(int count)
    {
        Console.Write("\b");
        string newStr = "";
        if (count % 4 == 0)
        {
            newStr = "-";
        }
        else if ((count - 1) % 4 == 0)
        {
            newStr = "\\";
        }
        else if ((count - 2) % 4 == 0)
        {
            newStr = "|";
        }
        else if ((count - 3) % 4 == 0)
        {
            newStr = "/";
        }
        Console.Write(newStr);
    }

    public abstract void PerformActivity();
}
