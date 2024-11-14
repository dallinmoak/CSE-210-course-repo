class Shape
{
  public Shape(string color)
  {
    this._color = color;
  }
  private string _color;
  public string Color
  {
    get { return _color; }
    set { _color = value; }
  }

  public virtual double GetArea()
  {
    return 0;
  }
}