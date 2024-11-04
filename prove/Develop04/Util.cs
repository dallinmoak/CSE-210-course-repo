using System.Security.Cryptography.X509Certificates;

class Util
{
    public void PrintSpinner(int count, int total)
    {
        if (count > 0)
        {
            Console.Write("\b");
        }
        char[] spinnerChars = new char[] { '-', '\\', '|', '/' };
        Console.Write(spinnerChars[count % spinnerChars.Length]);
        if (count == total - 1) Console.Write("\b ");
    }

    public void PrintCountdown(int count, int total)
    {
        string content = (total - count).ToString();
        Action<string> BackUp = (content) =>
        {
            for (int i = 0; i < content.Length; i++)
            {
                Console.Write("\b");
            }
        };
        if (count > 0) BackUp(content);
        Console.Write(content);
        if (count == total - 1)
        {
            BackUp(content);
            Console.Write(" ");
        }
    }
    public void DoWithDelay(Action f, int secs, Action<int, int> waitAction = null, int interval = 4, bool before = true)
    {
        waitAction ??= this.PrintSpinner;

        if (before) f();
        for (int i = 0; i < interval * secs; i++)
        {
            waitAction(i, (interval * secs));
            Thread.Sleep((int)Math.Round(1000.0 / interval));
        }
        if (!before) f();

    }

    private static Util _instance;
    private static readonly object _lock = new();

    private Util() { }

    public static Util Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Util();
                }
                return _instance;
            }
        }
    }
}