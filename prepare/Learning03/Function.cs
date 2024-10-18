class Fraction
{
  public Fraction(int wholeNumber)
  {
    this._top = wholeNumber;
    this._bottom = 1;
  }
  public Fraction(int top, int bottom)
  {
    this._bottom = bottom;
    this._top = top;
  }
  private int _bottom;
  private int _top;

  public int GetTop()
  {
    return this._top;
  }

  public void SetTop(int top)
  {
    this._top = top;
  }

  public int GetBottom()
  {
    return this._bottom;
  }

  public void SetBottom(int bottom)
  {
    this._bottom = bottom;
  }

  public string GetFractionString(bool forceFraction = false)
  {
    if (this._bottom == 1 && !forceFraction)
    {
      return this._top.ToString();
    }
    else
    {

      return this._top + "/" + this._bottom;
    }
  }

  public double GetDecimalValue()
  {
    return (double)this._top / this._bottom;
  }
}