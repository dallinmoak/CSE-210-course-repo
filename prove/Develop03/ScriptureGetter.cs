class ScriptureGetter
{
  public static Scripture GetScripture()
  {
    List<(string, string, int, int, int?)> scriptureData = [
        ("The Lord is my shepherd; I shall not want. \nHe maketh me to lie down in green pastures: he leadeth me beside the still waters. \nHe restoreth my soul: he leadeth me in the paths of righteousness for his name’s sake.","Psalm",23,1, 3),
        ("Finally, brethren, whatsoever things are true, whatsoever things are honest, whatsoever things are just, whatsoever things are pure, whatsoever things are lovely, whatsoever things are of good report; if there be any virtue, and if there be any praise, think on these things.","Philippians",4,8, null),
        ("Trust in the Lord with all thine heart; and lean not unto thine own understanding. \nIn all thy ways acknowledge him, and he shall direct thy paths.", "Proverbs", 3, 5,6),
        ("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.", "John", 3, 16, null),
        ("Jesus wept.", "John", 11, 35, null)
      ];
    bool doneGettingScripture = false;
    Scripture currentScripture = null;
    while (!doneGettingScripture)
    {
      Console.WriteLine("enter a scripture (s), use a built-in scripture (b), or quit (q)");
      string response = Console.ReadLine();
      (string, string, int, int, int?) currentInitData;
      if (response == "q")
      {
        doneGettingScripture = true;
        continue;
      }
      else if (response == "s")
      {
        Console.WriteLine("Enter the scripture text:");
        string text = Console.ReadLine();
        Console.WriteLine("Enter the book:");
        string book = Console.ReadLine();
        Console.WriteLine("Enter the chapter:");
        int chapter = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the verse or verse range:");
        string verseRange = Console.ReadLine();
        int starVerse;
        int? endVerse = null;
        if (verseRange.Contains("-"))
        {
          string[] verseRangeArray = verseRange.Split('-');
          starVerse = int.Parse(verseRangeArray[0]);
          endVerse = int.Parse(verseRangeArray[1]);
        }
        else
        {
          starVerse = int.Parse(verseRange);
        }
        currentScripture = new Scripture(text, endVerse.HasValue
          ? new Reference(book, chapter, starVerse, endVerse.Value)
          : new Reference(book, chapter, starVerse));
        doneGettingScripture = true;
      }
      else if (response == "b")
      {
        currentInitData = scriptureData[new Random().Next(scriptureData.Count)];
        var (text, book, chapter, startVerse, endVerse) = currentInitData;
        currentScripture = new Scripture(text, endVerse.HasValue
          ? new Reference(book, chapter, startVerse, endVerse.Value)
          : new Reference(book, chapter, startVerse));
        doneGettingScripture = true;
      }
      else
      {
        Console.WriteLine("Invalid response");
        continue;
      }
    }

    return currentScripture;
  }
}