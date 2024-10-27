using System.Text;

class Scripture
{
  public Scripture(string text, Reference refr)
  {
    buildWords(text);
    this._reference = refr.ToString();
  }

  private List<Word> words = new List<Word>();
  private string _reference;
  private void buildWords(string text)
  {
    string[] wordArray = text.Split(' ');
    foreach (string word in wordArray)
    {
      words.Add(new Word(word));
    }
  }
  public void DisplayScripture()
  {
    StringBuilder output = new StringBuilder();
    output.Append($"Scripture Reference: {this._reference}\n\"");
    foreach (Word word in words)
    {
      output.Append(word.ToString() + " ");
    }
    output.Length--; // remove the last space
    output.Append('"');
    Console.WriteLine(output.ToString());
  }

  public bool AllHidden()
  {
    foreach (Word word in words)
    {
      if (!word.GetHideState())
      {
        return false;
      }
    }
    return true;
  }
  public void HideAWord()
  {
    Word target = words[new Random().Next(words.Count)];
    if (target.GetHideState())
    {
      HideAWord();
    }
    else
    {
      target.Hide();
    }
  }
}