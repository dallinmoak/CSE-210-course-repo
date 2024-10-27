class Word
{
  public Word(string text)
  {
    this._text = text;
  }
  private string _text;
  private bool _isHidden;
  public void Hide()
  {
    this._isHidden = true;
  }

  public string ToString(bool alwaysShow = false)
  {
    if (alwaysShow)
    {
      return this._text;
    }
    return this._isHidden ? new string('_', this._text.Length) : this._text;
  }

  public bool GetHideState()
  {
    return this._isHidden;
  }

}