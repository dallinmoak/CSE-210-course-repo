class Reference
{
  public Reference(string book, int chapter, int start_verse, int end_verse)
  {
    this._book = book;
    this._chapter = chapter;
    this._verseRange = $"{start_verse}-{end_verse}";
  }

  public Reference(string book, int chapter, int verse)
  {
    this._book = book;
    this._chapter = chapter;
    this._verseRange = verse.ToString();
  }

  private string _book;
  private int _chapter;
  private string _verseRange;

  public override string ToString()
  {
    return $"{this._book} {this._chapter}:{this._verseRange}";
  }
}
